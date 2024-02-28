using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Linq;
using AssetStudio;
using BaseJumper.Editor;
#pragma warning disable CS0051

namespace BaseJumper.Editor {
    public partial class BaseJumper_Editor : EditorWindow, IDisposable {
        public BaseJumper_Editor() : base() {
            totalProgress = new Progress(DisplayProgressBar, ClearProgressBar);
        }
        static BaseJumper_Editor Instance {
            get {
				if (instance == null) {
					Instance = ScriptableObject.CreateInstance<BaseJumper_Editor>();
				}
                return instance;
			} set {
                instance = value;
            }
        }
        static BaseJumper_Editor instance;
        private bool compress;
        readonly Progress totalProgress;
        bool isRunning;
        static EditorWindow Window => GetWindow(typeof(BaseJumper_Editor));

        public void Update() {
            totalProgress.Update();
        }

        [MenuItem("BaseJumper/Debug/Reset")]
        static void Reset_Static() {
            instance?.Dispose();
            Instance = ScriptableObject.CreateInstance<BaseJumper_Editor>();
        }
        public void Dispose() {
            totalProgress.Clear();
            ClearProgressBar();
            Window.Close();
            isRunning = false;
            instance = null;
        }
        /*
        [MenuItem("BaseJumper/Debug/OpenWindow")]
        static void OpenWindow_Static() {
            Window.Show();
        }
        */
        [MenuItem("BaseJumper/Debug/DebuggerPause")]
        static void DebuggerPause() {
            var instance = Instance;
            System.Diagnostics.Debugger.Break();
        }
        [MenuItem("BaseJumper/Build AssetBundles")]
        static async Task Build() {
            if (Instance.isRunning) {return;}
            Instance.isRunning = true;
            Instance.compress = true;
            await Instance.BuildAllAssetBundles();
        }
        [MenuItem("BaseJumper/Build AssetBundles (No Compression)")]
        static async Task BuildNoCompress() {
            if (Instance.isRunning) {return;}
            Instance.isRunning = true;
            Instance.compress = false;
            await Instance.BuildAllAssetBundles();
        }
        [MenuItem("BaseJumper/Compress Existing Bundles")]
        static async Task CompressExisting_Static() {
            if (Instance.isRunning) {return;}
            Instance.isRunning = true;
            await Instance.CompressExisting();
        }
        async Task CompressExisting() {
            try {
                var allBundles = GetAllFiles();
                Window.Show();
                await CompressAll(allBundles);
            } catch (AggregateException ae) {
                ae.Flatten().Handle(ex => {
                    UnityEngine.Debug.LogException(ex);
                    return true;
                });
            } catch (Exception ex) {
                UnityEngine.Debug.LogException(ex);
            } finally {
                CleanUp();
            }
        }
        /*
        [MenuItem("BaseJumper/Debug/Test AssetStudio")]
        static void AssetStudioTest_Static() {
            if (Instance.isRunning) {return;}
            Instance.isRunning = true;
            var allBundles = GetAllFiles();
            Instance.AssetStudio_Rectify(allBundles);
            Instance.CleanUp();
        }
        */
        static void DisplayProgressBar(object _, IOnUpdateArgs args) {
			EditorUtility.DisplayProgressBar(args.Title, args.Message, args.Progress);
		}
        static void ClearProgressBar() {
			EditorUtility.ClearProgressBar();
            Window.Close();
		}
        void AssetStudio_Rectify(IEnumerable<FileInfo> bundles) {
            if (!VerifyLocation()) {throw new InvalidOperationException("Invalid LoR folder setting");}
            AssetStudio.Logger.Default = new SpecialLogger();
            Window.Show();
            // const string tempPath = "F:/Temp/LoR_Extract/Temp";
			var mainManager = new AssetsManager {
				ProgressManager = totalProgress,
				LoRPath = LocationString
			};
            var vanillaDirectory = Location;
            var vanillaAssetBundleDirectoryInfo = vanillaDirectory.EnumerateDirectories("LibraryOfRuina_Data").First();
            DirectoryInfo coreVanillaAdditionalBundleDirectoryInfo = null;
            DirectoryInfo nonCoreVanillaBundleDirectoryInfo = null;
            foreach (var dir in vanillaAssetBundleDirectoryInfo.EnumerateDirectories()) {
                switch (dir.Name) {
                    case "Resources":
                        coreVanillaAdditionalBundleDirectoryInfo = dir;
                        break;
                    case "StreamingAssets":
                        nonCoreVanillaBundleDirectoryInfo = dir;
                        break;
                }
            }
            var coreVanillaBundlesQuery = vanillaAssetBundleDirectoryInfo
                .EnumerateFiles()
                .Where(IsValidVanillaBundle);
            foreach (var file in coreVanillaAdditionalBundleDirectoryInfo.EnumerateFiles()) {
                switch (file.Name) {
                    case "unity default resources":
                    case "unity_builtin_extra":
                        coreVanillaBundlesQuery = coreVanillaBundlesQuery.Append(file);
                        break;
                }
            }
            var coreVanillaBundles = coreVanillaBundlesQuery.ToList();
            var coreVanillaBundleNames = coreVanillaBundles
                .ToDictionary(x => x.Name, x => x.FullName, StringComparer.OrdinalIgnoreCase);
            var allVanillaBundles = coreVanillaBundles.Concat(
                nonCoreVanillaBundleDirectoryInfo
                    .EnumerateFiles("*.*", SearchOption.AllDirectories)
                    .Where(IsValidVanillaBundle));
            var allVanillaBundleNames = allVanillaBundles
                .ToDictionary(x => x.Name, x => x.FullName, StringComparer.OrdinalIgnoreCase);

            AssetsManager NewManager() {
                return new AssetsManager {
				    ProgressManager = totalProgress,
                    LoRPath = LocationString
                };
            }
            var vanillaManagers = new Dictionary<string, AssetsManager>();

            AssetsManager GetVanillaManagersForFile(SerializedFile file) {
				return GetManager(GetOriginalName(file));
            }
            IEnumerable<AssetStudio.Object> GetObjectsForManager(AssetsManager manager) {
                return manager.assetsFileList.SelectMany(x => x.Objects);
            }
            IEnumerable<AssetStudio.Object> GetVanillaObjectsForFile(SerializedFile file) {
				return GetObjectsForManager(GetVanillaManagersForFile(file));
            }
            /*
            IEnumerable<AssetsManager> GetVanillaManagersForFiles(IEnumerable<SerializedFile> files) {
				return files
                    .Select(file => GetOriginalName(file))
                    .Select(x => GetManager(x));
            }
            IEnumerable<AssetStudio.Object> GetObjectsForManagers(IEnumerable<AssetsManager> managers) {
                return managers.SelectMany(x => x.assetsFileList).SelectMany(x => x.Objects);
            }
            IEnumerable<AssetStudio.Object> GetVanillaObjectsForFiles(IEnumerable<SerializedFile> files) {
				return GetObjectsForManagers(GetVanillaManagersForFiles(files));
            }
            */

            AssetsManager GetManager(string fileName) {
				if (!vanillaManagers.TryGetValue(fileName, out var manager)) {
					manager = NewManager();
					if (allVanillaBundleNames.TryGetValue(fileName, out var fullName)) {
						manager.LoadFiles(fullName);
					} else {
						Debug.LogError("Couldn't find vanilla manager");
					}
					vanillaManagers.Add(fileName, manager);
				}
                return manager;
			}

			bool IsVanillaName(string name) => allVanillaBundleNames.ContainsKey(name);

            var allBundlePaths = bundles.Select(x => x.FullName);

			try {
                mainManager.LoadFiles(allBundlePaths.ToArray());
                var mainManager_assetsFileList_NoCompressed = mainManager.assetsFileList
                    .Where(x => !IsVanillaName(GetOriginalName(x)))
                    .Where(x => mainManager.readerBundleFiles[x.reader].compressionType == AssetStudio.CompressionType.None)
                    .ToList();
                if (mainManager_assetsFileList_NoCompressed.Count <= 0) {
                    return;
                }
                var objectContainerNameDicMain = mainManager_assetsFileList_NoCompressed
                    .SelectMany(x => x.objectContainerNameDic)
                    .DistinctBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);
				var fileExternals = mainManager_assetsFileList_NoCompressed.ToDictionary(x => x, x => x.TryGetExternalFiles());
				var validExternals = fileExternals.ToDictionary(e => e.Key, e => {
                    var temp = e.Value.Select((x, index) => {
                        var (identifier, file) = x;
                        return (index, identifier, file);
                    });
                    var temp2 = temp.Where((x) => {
                        var (_, identifier, file) = x;
                        if (file == null || identifier == null) {return false;}
                        var originName = GetOriginalName(file);
						return IsVanillaName(originName);
                    });
                    var temp3 = temp2.ToDictionary(x => x.index, x => {
                        var (index, identifier, file) = x;
                        return (identifier, file);
                    });
                    return temp3;
                });

                var pptrsAll = mainManager_assetsFileList_NoCompressed.ToDictionary(x => x, x =>
				{
                    try {
					    return GetPPtrsForFile(x, validExternals[x]);
                    } catch (Exception ex) {
                        Debug.LogError($"{GetOriginalName(x)} had a fatal error getting PPtrs");
                        Debug.LogException(ex);
                        return null;
                    }
				});
                foreach (var entry in pptrsAll) {
                    if (entry.Value == null) {continue;}
                    if (IsVanillaName(GetOriginalName(entry.Key))) {continue;}
                    try {
					    ProccessFile(entry.Key, entry.Value);
                    } catch (Exception ex) {
                        Debug.LogError($"{GetOriginalName(entry.Key)} had a fatal error while processing{Environment.NewLine}{ex}");
                    }
                }

                void ProccessFile(SerializedFile file, IEnumerable<PPtrOffset> pptrs) {
                    var originalName = GetOriginalName(file);
                    var validExternalsForFile = validExternals[file];
                    var pptrsFiles = pptrs.Select(pptrOffset => {
                        bool success;
                        var pptr = pptrOffset.pptr;
                        AssetStudio.Object obj;
                        try {
                            success = pptr.TryGet(out obj);
                            Debug.Assert(success, $"{originalName}: PPtr {pptr.m_FileID}:{pptr.m_PathID} couldn't find target.");
                        } catch (OutOfMemoryException) {
                            // success = false;
                            obj = null;
                            Debug.LogWarning($"{originalName}: PPtr {pptr.m_FileID}:{pptr.m_PathID} ran out of memory.");
                        }
                        return (pptrOffset, obj);
                    });
                    var pptrsNamedFiles = pptrsFiles.Select(x => {
                        var obj = x.obj as NamedObject;
                        return (x.pptrOffset, obj);
                    }).Where(x => x.obj != null)
                    .ToList();
                    var namedFilesPPtrsLookup = pptrsNamedFiles.GroupBy(
                        x => x.obj,
                        x => x.pptrOffset
                    );
                    var namedFilesByFileId = pptrsNamedFiles.GroupBy(
                        x => x.pptrOffset.pptr.m_FileID,
                        x => x.obj
                    );
                    /*
                    foreach (var entry in namedFilesByFileId) {
                        var hashset = new HashSet<NamedObject>(entry);
                        var allOthers = namedFilesByFileId
                            .Where(x => x.Key != entry.Key)
                            .SelectMany(x => x);
                        foreach (var obj in allOthers) {
                            if (hashset.Contains(obj)) {
                                throw new InvalidOperationException(
                                    "Same object somehow exists in multiple files"
                                );
                            }
                        }
                    }
                    */

                    string GetNamedObjectName(AssetStudio.Object obj) {
                        switch (obj)
                        {
                            case AssetStudio.GameObject m_GameObject:
                                return m_GameObject.m_Name;
                            case AssetStudio.Texture2D m_Texture2D:
                                /*
                                if (!string.IsNullOrEmpty(m_Texture2D.m_StreamData?.path))
                                    assetItem.FullSize = asset.byteSize + m_Texture2D.m_StreamData.size;
                                */
                                return m_Texture2D.m_Name;
                            case AssetStudio.AudioClip m_AudioClip:
                                /*
                                if (!string.IsNullOrEmpty(m_AudioClip.m_Source))
                                    assetItem.FullSize = asset.byteSize + m_AudioClip.m_Size;
                                */
                                return m_AudioClip.m_Name;
                            case AssetStudio.VideoClip m_VideoClip:
                                /*
                                if (!string.IsNullOrEmpty(m_VideoClip.m_OriginalPath))
                                    assetItem.FullSize = asset.byteSize + (long)m_VideoClip.m_ExternalResources.m_Size;
                                */
                                return m_VideoClip.m_Name;
                            case AssetStudio.Shader m_Shader:
                                return m_Shader.m_ParsedForm?.m_Name ?? m_Shader.m_Name;
                            case AssetStudio.Mesh _:
                            case AssetStudio.TextAsset _:
                            case AssetStudio.AnimationClip _:
                            case AssetStudio.Font _:
                            case AssetStudio.MovieTexture _:
                            case AssetStudio.Sprite _:
                                return ((NamedObject)obj).m_Name;
                            case AssetStudio.Animator m_Animator:
                                if (m_Animator.m_GameObject.TryGet(out var gameObject))
                                {
                                    return gameObject.m_Name;
                                }
                                break;
                            case AssetStudio.MonoBehaviour m_MonoBehaviour:
                                if (m_MonoBehaviour.m_Name == "" && m_MonoBehaviour.m_Script.TryGet(out var m_Script))
                                {
                                    return m_Script.m_ClassName;
                                }
                                else
                                {
                                    return m_MonoBehaviour.m_Name;
                                }
                            case AssetStudio.PlayerSettings m_PlayerSettings:
                                return m_PlayerSettings.productName;
                            case AssetStudio.AssetBundle m_AssetBundle:
                                /*
                                foreach (var m_Container in m_AssetBundle.m_Container)
                                {
                                    var preloadIndex = m_Container.Value.preloadIndex;
                                    var preloadSize = m_Container.Value.preloadSize;
                                    var preloadEnd = preloadIndex + preloadSize;
                                    for (int k = preloadIndex; k < preloadEnd; k++)
                                    {
                                        containers.Add((m_AssetBundle.m_PreloadTable[k], m_Container.Key));
                                    }
                                }
                                */
                                return m_AssetBundle.m_Name;
                            case AssetStudio.ResourceManager m_ResourceManager:
                                /*
                                foreach (var m_Container in m_ResourceManager.m_Container)
                                {
                                    containers.Add((m_Container.Value, m_Container.Key));
                                }
                                */
                                break;
                            case AssetStudio.NamedObject m_NamedObject:
                                return m_NamedObject.m_Name;
                        }
                        //FallBack
                        if (obj is AssetStudio.NamedObject namedObj) {
                            return namedObj.m_Name;
                        } else {
                            return string.Empty;
                        }
                    }
                    // var pptrsNamedFilesLookup = pptrsNamedFiles.ToDictionary(GetNamedObjectName);
                    var pptrsNamedFilesLookupDic = namedFilesByFileId.ToDictionary(
                        x => x.Key,
                        x => x.Distinct().ToLookup(GetNamedObjectName)
                    );
                    var identifierDic = validExternalsForFile.ToDictionary(
                        x => x.Value.file,
                        x => x.Value.identifier
                    );
                    var newIdentifierDic = new Dictionary<FileIdentifier, SerializedFile>();

                    var vanillaNamedObjs = validExternalsForFile.ToDictionary(
                        x => x.Key,
                        x => GetVanillaObjectsForFile(x.Value.file).OfType<NamedObject>().Distinct().ToList()
                    );
                    /*
                    var RefdFilesLookupDic = vanillaNamedObjs.ToDictionary(
                        x => x.Key,
                        x => x.Value
                            .Where(y => pptrsNamedFilesLookup[x.Key].Contains(GetNamedObjectName(y)))
                            .ToLookup(GetNamedObjectName)
                    );
                    */
                    var reRefDic = new Dictionary<AssetStudio.Object, AssetStudio.Object>();

                    foreach (var dicEntry in pptrsNamedFilesLookupDic) {
                        var fileIndex = dicEntry.Key;
                        if (fileIndex == 0) {continue;}
                        // var RefdFilesLookup = RefdFilesLookupDic[fileIndex];
                        var RefdFilesLookup = vanillaNamedObjs[fileIndex].ToLookup(GetNamedObjectName);
                        foreach (var group in dicEntry.Value) {
                            foreach (var obj in group) {
                                try {
                                    string name = GetNamedObjectName(obj);
                                    var typeFilter = RefdFilesLookup[name]
                                        .Where(x => x.GetType() == obj.GetType())
                                        .ToList();
                                    if (typeFilter.Count <= 0) {
                                        return;
                                    }
                                    if (typeFilter.Count == 1) {
                                        reRefDic.Add(obj, typeFilter.First());
                                        continue;
                                    }
                                    if (TryContainerID()) {continue;}
                                    bool TryContainerID() {
                                        var multiTuple = GetContainerObjList(file, obj, typeFilter);
                                        var containerEqualityList = multiTuple.Where(tuple => {
                                            if (string.Equals(tuple.originSet.container,
                                                tuple.newSet.newContainer,
                                                StringComparison.OrdinalIgnoreCase))
                                            {
                                                return true;
                                            }
                                            return false;
                                        }).ToList();
                                        if (containerEqualityList.Count >= 1) {
                                            if (containerEqualityList.Count == 1) {
                                                var (originSet, newSet) = containerEqualityList[0];
                                                reRefDic.Add(originSet.originObj, newSet.newObj);
                                                return true;
                                            }
                                            typeFilter = containerEqualityList.Select(tuple => tuple.newSet.newObj).ToList();
                                        }
                                        if (obj is AssetStudio.Sprite spr) {
                                            if (spr.m_RD.texture.TryGet(out var tex)) {
                                                string newName = GetNamedObjectName(tex);
                                                var newFilter = RefdFilesLookup[newName]
                                                    .Where(x => x.GetType() == tex.GetType());
                                                var texTuples = GetContainerObjList(file, tex, newFilter).ToList();
                                                if (texTuples.Count == 1) {
                                                    var (originSet, newSet) = texTuples[0];
                                                    var equalTexs = typeFilter.OfType<AssetStudio.Sprite>().Where(s => {
                                                        if (s.m_RD.texture.TryGet(out var newTex)) {
                                                            if (newTex == (AssetStudio.Texture2D)newSet.newObj) {
                                                                return true;
                                                            }
                                                        }
                                                        return false;
                                                    }).ToList();
                                                    if (equalTexs.Count >= 1) {
                                                        if (equalTexs.Count == 1) {
                                                            reRefDic.Add(obj, equalTexs[0]);
                                                            return true;
                                                        } else {
                                                            typeFilter = equalTexs.Cast<NamedObject>().ToList();
                                                        }
                                                    }
                                                }
                                            }
                                            if (spr.m_SpriteAtlas.TryGet(out var atlas)) {
                                                throw new NotImplementedException(
                                                    $"Sprite Atlas {atlas.m_Name}: Base game has no Sprite Atlases, and automatic re-referencing of sprites inside them is currently only partially supported."
                                                );
                                                /*
                                                string newName = GetNamedObjectName(atlas);
                                                var newFilter = RefdFilesLookup[newName]
                                                    .Where(x => x.GetType() == atlas.GetType());
                                                var atlasTuples = GetContainerObjList(file, atlas, newFilter).ToList();
                                                if (atlasTuples.Count == 1) {
                                                    var (originSet, newSet) = atlasTuples[0];
                                                    var equalAtlases = typeFilter.OfType<AssetStudio.Sprite>().Where(s => {
                                                        if (s.m_RD.texture.TryGet(out var newAtlas)) {
                                                            if (newAtlas == (AssetStudio.Texture2D)newSet.newObj) {
                                                                return true;
                                                            }
                                                        }
                                                        return false;
                                                    }).ToList();
                                                    if (equalAtlases.Count >= 1) {
                                                        if (equalAtlases.Count == 1) {
                                                            reRefDic.Add(obj, equalAtlases[0]);
                                                            return true;
                                                        } else {
                                                            typeFilter = equalAtlases.Cast<NamedObject>().ToList();
                                                        }
                                                    }
                                                }
                                                */
                                            }
                                        }
                                        return false;
                                    }
                                    if (TryPathID()) {continue;}
                                    bool TryPathID() {
                                        foreach (var newObj in typeFilter) {
                                            if (newObj.m_PathID == obj.m_PathID) {
                                                reRefDic.Add(obj, newObj);
                                                return true;
                                            }
                                        }
                                        return false;
                                    }
                                    switch (obj) {
                                        case AssetStudio.Sprite spr:
                                            var sprFilter = typeFilter.Cast<AssetStudio.Sprite>()
                                                .Where(x => x.m_PixelsToUnits == spr.m_PixelsToUnits)
                                                .ToList();
                                            if (sprFilter.Count > 1) {
                                                if (TryRawData(sprFilter)) {continue;}
                                                AssetStudio.Logger.Error($"{originalName}: Asset {name} has multiple possible targets");
                                            } else if (sprFilter.Count == 1) {
                                                reRefDic.Add(spr, sprFilter.First());
                                                continue;
                                            }
                                            break;
                                        case AssetStudio.Texture2D tex:
                                            var texFilter = typeFilter.Cast<AssetStudio.Texture2D>()
                                                .Where(x => x.m_Height == tex.m_Height && x.m_Width == tex.m_Width)
                                                .ToList();
                                            if (texFilter.Count > 1) {
                                                if (TryRawData(texFilter)) {continue;}
                                                AssetStudio.Logger.Error($"{originalName}: Asset {name} has multiple possible targets");
                                            } else if (texFilter.Count == 1) {
                                                reRefDic.Add(tex, texFilter.First());
                                                continue;
                                            }
                                            break;
                                        default:
                                            if (TryRawData(typeFilter)) {continue;}
                                            break;
                                    }
                                    bool TryRawData(IEnumerable<NamedObject> filteredObjs) {
                                        var list = filteredObjs.ToList();
                                        var byteSize = obj.byteSize;
                                        var subList = list.Where(x => x.byteSize == byteSize);
										IEnumerable<KeyValuePair<NamedObject, byte[]>> rawDic;
                                        var rawData = obj.GetRawData();
                                        bool validEquals;

                                        if (subList.Any()) {
                                            rawDic = subList.ToDictionary(x => x, x => x.GetRawData());
                                            validEquals = true;
                                        } else {
                                            rawDic = list.ToDictionary(x => x, x => x.GetRawData());
                                            /*
											var equalDataLengths = rawDic.Where(x => x.Value.Length == rawData.Length);
                                            if (equalDataLengths.Any()) {
                                                rawDic = equalDataLengths;
                                                validEquals = true;
                                            } else {
                                                validEquals = false;
                                            }
                                            */
                                            validEquals = false;
                                        }

                                        int currentDiff = int.MaxValue;
                                        var resultList = new List<NamedObject>();
                                        foreach (var entry in rawDic) {
                                            var subObj = entry.Key;
                                            var subObjRawData = entry.Value;
                                            bool[] debugAry;
                                            if (validEquals) {
												debugAry = new bool[byteSize];
                                                for (int i = 0; i < byteSize; i++) {
                                                    debugAry[i] = rawData[i] == subObjRawData[i];
                                                }
                                            } else {
                                                bool aryFlip = rawData.Length < subObjRawData.Length;
                                                var shortData = aryFlip ? rawData : subObjRawData;
                                                var longData = aryFlip ? subObjRawData : rawData;
                                                debugAry = new bool[longData.Length];
                                                int i;
                                                for (i = 0; i < shortData.Length; i++) {
                                                    debugAry[i] = rawData[i] == subObjRawData[i];
                                                }
                                                for (_ = 0; i < longData.Length; i++) {
                                                    debugAry[i] = false;
                                                }
                                            }
                                            var arrayEqual = debugAry.Sum(x => x ? 0 : 1);
                                            if (arrayEqual <= 0) {
                                                reRefDic.Add(obj, subObj);
                                                return true;
                                            } else {
                                                if (arrayEqual <= currentDiff) {
                                                    if (arrayEqual < currentDiff) {
                                                        resultList.Clear();
                                                    }
                                                    resultList.Add(subObj);
                                                }
                                            }
                                        }
                                        if (resultList.Count == 1) {
                                            AssetStudio.Logger.Warning($"{originalName}: Asset {name} has multiple possible targets, using closest match");
                                            reRefDic.Add(obj, resultList[0]);
                                            return true;
                                        }
                                        return false;
                                    }
                                } catch (Exception ex) {
                                    Debug.LogException(ex);
                                }
                            }
                        }
                    }

                    // var hintDic = new Dictionary<FileIdentifier, List<FileIdentifier>>();

                    foreach (var grouping in namedFilesPPtrsLookup) {
                        var obj = grouping.Key;
						if (obj == null) {
                            foreach (var entry in grouping) {
                                Debug.LogError($"{originalName}: PPtr {entry.pptr.m_FileID}:{entry.pptr.m_FileID} couldn't find a target!");
                            }
                            continue;
                        }
                        if (!reRefDic.TryGetValue(obj, out var newObj)) {
                            Debug.LogWarning($"{originalName}: PPtr for {GetNamedObjectName(obj)} couldn't find a new target");
                            continue;
                        }
                        if (identifierDic.TryGetValue(obj.assetsFile, out var identifier)) {
                            newIdentifierDic[identifier] = newObj.assetsFile;
                        }
                        foreach (var entry in grouping) {
                            entry.WritePathId(newObj.m_PathID);
                        }
                    }

                    foreach (var entry in newIdentifierDic) {
                        FileIdentifier identifier = entry.Key;
                        SerializedFile newIdentifier = entry.Value;
                        // identifier.guid = newIdentifier.guid;
                        // identifier.type = newIdentifier.type;
                        if (newIdentifier.fileName.StartsWith("cab", StringComparison.OrdinalIgnoreCase)) {
                            identifier.PathName = $"archive:/{newIdentifier.fileName}/{newIdentifier.fileName}";
                        } else {
                            identifier.PathName = newIdentifier.fileName;
                        }
                        identifier.Write();
                    }

                    bool willPrintString = false;
                    var sb = new StringBuilder($"{originalName} will need the following dependencies:");
                    sb.AppendLine();
                    foreach (var entry in validExternalsForFile.Values) {
                        var curFile = entry.file;
                        var curName = GetOriginalName(curFile);
                        if (!coreVanillaBundleNames.ContainsKey(curName)) {
                            sb.Append(" ");
                            sb.AppendLine(curName);
                            willPrintString = true;
                        }
                    }
                    if (willPrintString) {
                        Debug.Log(sb);
                    }
                }

                foreach (var file in mainManager_assetsFileList_NoCompressed) {
					if (IsVanillaName(GetOriginalName(file))) {continue;}
                    var serializedReader = file.reader;
                    serializedReader.Position = 0;
                    var streamFile = mainManager.readerStreamFiles[serializedReader];
                    var bundle = mainManager.readerBundleFiles[serializedReader];
                    if (bundle.compressionType != AssetStudio.CompressionType.None) {
                        Debug.LogError("Compression type somehow changed during processing");
                        continue;
                    }
                    var reader = bundle.reader;
                    reader.Position = streamFile.offset + bundle.blocksStreamOffset;
                    serializedReader.BaseStream.CopyTo(reader.BaseStream);
                    /*
                    using (var writeStream = new FileStream($"{tempPath}/temp-{GetOriginalName(file)}", FileMode.Create, FileAccess.Write, FileShare.Write)) {
                        reader.Position = 0;
                        reader.BaseStream.CopyTo(writeStream);
                        writeStream.Position = streamFile.offset + bundle.blocksStreamOffset;
                        serializedReader.BaseStream.CopyTo(writeStream);
                    }
                    */
                }
                /*
                if (System.Diagnostics.Debugger.IsAttached) {
                    System.Diagnostics.Debugger.Break();
                }
                */
            } finally {
                mainManager.Dispose();
                foreach (var manager in vanillaManagers.Values) {
                    manager.Dispose();
                }
                // CleanUp();
            }
        }

        private static bool IsValidVanillaBundle(FileInfo file) {
            var extension = file.Extension;
            if (!string.IsNullOrEmpty(extension)) {
			    return IsValidVanillaBundleExtension(extension);
            } else {
                return IsValidVanillaBundleName(file.Name);
            }
        }
        private static bool IsValidVanillaBundle(string path) {
            var extension = Path.GetExtension(path);
            if (!string.IsNullOrEmpty(extension)) {
			    return IsValidVanillaBundleExtension(extension);
            } else {
                return IsValidVanillaBundleName(Path.GetFileName(path));
            }
        }
		private static bool IsValidVanillaBundleName(string name) {
            name = name.ToLowerInvariant();
            switch (name) {
                case "level0":
                case "level1":
                case "level2":
                case "level3":
                    return true;
                default:
                    return false;
            }
        }
		private static bool IsValidVanillaBundleExtension(string ext) {
            ext = ext.ToLowerInvariant();
            switch (ext) {
                case ".pres":
                case ".assets":
                    return true;
                default:
                    return false;
            }
        }

		private static IEnumerable<((NamedObject originObj, string container) originSet, (NamedObject newObj, string newContainer) newSet)>
            GetContainerObjList(SerializedFile file, NamedObject originObj, IEnumerable<NamedObject> originFilter)
		{
			// REVIEW - File check might not be neccecary
			if (!file.objectContainerNameDic.TryGetValue(originObj, out var container) &&
				!originObj.assetsFile.objectContainerNameDic.TryGetValue(originObj, out container))
			{
				return null;
			}
			container = Path.GetFileName(container);
			var tempFilter = originFilter.Select(newObj =>
			{
				if (newObj.assetsFile.objectContainerNameDic.TryGetValue(newObj, out var newContainer))
				{
					newContainer = Path.GetFileName(newContainer);
					return ((originObj, container), (newObj, newContainer));
				}
				return ((null, null), (null, null));
			});
            var noNull = tempFilter.Where(multiTuple => {
				var (set1, set2) = multiTuple;
				(NamedObject entry1, string entry2) = set1;
				(NamedObject entry3, string entry4) = set2;
                if (entry1 == null && entry2 == null && entry3 == null && entry4 == null) {return false;}
                else {return true;}
            });
			return noNull;
		}
		public static string GetOriginalName(SerializedFile file) => file.GetOriginalName();
		private static IEnumerable<PPtrOffset> GetPPtrsForFile(SerializedFile file,
			Dictionary<int, (FileIdentifier identifier, SerializedFile file)> validExternals)
		{
			var tempObjectTypesList = file.Objects.Select(x => {
                try {
				    return TypeTreeHelper.GetObjectData(x);
                } catch (OutOfMemoryException ex) {
                    // Aborts for entire file on OOM due to potential writing errors.
                    if (x is NamedObject obj) {
                        Debug.LogError($"{GetOriginalName(x.assetsFile)}: Object {obj.m_Name}:{obj.m_PathID} threw OOM getting data, aborting.{Environment.NewLine}{ex}");
                    } else {
                        Debug.LogError($"{GetOriginalName(x.assetsFile)}: Object {x.m_PathID} threw OOM getting data, aborting.{Environment.NewLine}{ex}");
                    }
                    throw ex;
                } catch (Exception ex) {
                    if (x is NamedObject obj) {
                        Debug.LogWarning($"{GetOriginalName(x.assetsFile)}: Object {obj.m_Name}:{obj.m_PathID} threw an exception getting data.{Environment.NewLine}{ex}");
                    } else {
                        Debug.LogWarning($"{GetOriginalName(x.assetsFile)}: Object {x.m_PathID} threw an exception getting data.{Environment.NewLine}{ex}");
                    }
                    return null;
                }
			}).Where(x => x != null);
			var filteredList = tempObjectTypesList.Where(x =>
				x.dataList.Any(d => d.m_Type.StartsWith("PPtr", StringComparison.Ordinal) && CheckDic(d.value))
			);
			var filteredDictionary = filteredList.GroupBy(
				x => x,
				x => x.dataList.Where(d => d.m_Type.StartsWith("PPtr", StringComparison.Ordinal) && CheckDic(d.value))
			);
			bool CheckDic(object obj)
			{
				if (!(obj is OrderedDictionary dic))
				{
					return false;
				}
				foreach (DictionaryEntry entry in dic)
				{
					if (entry.Key is string key)
					{
						if (string.Equals(key, "m_FileID", StringComparison.Ordinal))
						{
							object value = entry.Value;
							return validExternals.ContainsKey((int)value);
						}
					}
				}
				return false;
			}
			var pptrs = filteredDictionary.SelectMany(grouping =>
			{
				ObjectReader objReader = grouping.Key.obj.reader;
				var newPPtrs = new List<PPtrOffset>();
				foreach (var group in grouping)
				{
					foreach (var entry in group)
					{
						var obj = entry.value;
						if (!(obj is OrderedDictionary dic))
						{
							continue;
						}
						newPPtrs.Add(new PPtrOffset(entry.m_Node, objReader, entry.offset));
					}
				}
				return newPPtrs;
			});
			return pptrs;
		}
        void CleanUp() {
            totalProgress.Clear();
            isRunning = false;
        }
        async Task BuildAllAssetBundles() {
            try {
                string assetBundleDirectory = "Assets/AssetBundles";
                var manifest = BuildPipeline.BuildAssetBundles(assetBundleDirectory,
                    BuildAssetBundleOptions.UncompressedAssetBundle,
                    UnityEditor.BuildTarget.StandaloneWindows64);
                // var allBundlesDebug = manifest.GetAllAssetBundles();
                var allBundles = GetAllFiles(assetBundleDirectory).ToList();
                Window.Show();
                await RectifyReferences(allBundles);
                AssetStudio_Rectify(allBundles);
                if (compress) {
                    await CompressAll(allBundles);
                }
            } catch (AggregateException ae) {
                ae.Flatten().Handle(ex => {
                    UnityEngine.Debug.LogException(ex);
                    return true;
                });
            } catch (Exception ex) {
                UnityEngine.Debug.LogException(ex);
            } finally {
                CleanUp();
            }
        }
        /*
        void UpdateProgress() {
            if (!progressValues.Any()) {
                EditorUtility.ClearProgressBar();
                return;
            }
            var firstEntry = progressValues.First();
            var progress = firstEntry.Value;
            var fileName = firstEntry.Key.Name;
            if (progress <= .5f) {
                EditorUtility.DisplayProgressBar("Processing AssetBundles", $"Parsing AssetBundle {fileName}", progress);
            } else {
                EditorUtility.DisplayProgressBar("Processing AssetBundles", $"Writing AssetBundle {fileName}", progress);
            }
        }
        */
        async Task RectifyReferences(IEnumerable<FileInfo> bundles) {
            var bundleTasks = new List<Task>();
            foreach (var bundle in bundles) {
                bundleTasks.Add(HandleBundle(bundle));
            }
            await Task.WhenAll(bundleTasks);
        }
        async Task CompressAll(IEnumerable<FileInfo> bundles) {
            var bundleTasks = new List<Task>();
            foreach (var bundle in bundles) {
				var progress = totalProgress.NewProgress("Compressing AssetBundle", $"Compressing AssetBundle {bundle.Name}");
                bundleTasks.Add(Recompress(bundle, progress));
            }
            await Task.WhenAll(bundleTasks);
        }
        static IEnumerable<FileInfo> GetAllFiles(string assetBundleDirectory = "Assets/AssetBundles") {
            var assetBundleDirectoryInfo = new DirectoryInfo(assetBundleDirectory);
            if (!assetBundleDirectoryInfo.Exists) {
                assetBundleDirectoryInfo.Create();
            }
            return GetAllFilesInDir(assetBundleDirectoryInfo);
        }
        static IEnumerable<FileInfo> GetAllFilesInDir(DirectoryInfo dir) {
            return dir.EnumerateFiles().Where(bundle => {
                if (string.Equals(bundle.Extension, ".manifest", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(bundle.Extension, ".meta", StringComparison.OrdinalIgnoreCase)) {return false;}
                if (string.Equals(bundle.Name, "AssetBundles", StringComparison.Ordinal)) {return false;}
                return true;
            });
        }
        async Task HandleBundle(FileInfo bundle) {
            var fileName = bundle.Name;
            const string progressTitle = "Processing AssetBundles";
			var progress_Writing = totalProgress.NewProgress(progressTitle, $"Writing AssetBundle {fileName}");
            var progress_Parse = totalProgress.NewProgress(progressTitle, $"Parsing AssetBundle {fileName}");
            /*
            BaseJumper.Editor.Progress.ProgressInstance progress_Compress = null;
            if (compress) {
                progress_Compress = totalProgress.NewProgress(progressTitle, $"Compressing AssetBundle {fileName}");
            }
            */
            const byte literalB = 66;
            const int bufferSize = 0x800000;
            const string readDll = "BaseJumper_Hook.dll";
            const string writeDll = "Assembly-CSharp.dll";
            var writeDllBytes = Encoding.ASCII.GetBytes(writeDll);
            const int nameLength = 19;
            FileStream stream = null;
            try {
                stream = new FileStream(
                    bundle.FullName,
                    FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                    bufferSize: bufferSize, useAsync: true);
                byte[] bytes = new byte[bufferSize];
                byte[] lastBytes = null;
                int maxBlocks = UnityEngine.Mathf.CeilToInt((float)stream.Length / (float)bufferSize);
                byte[][] changedBytes = new byte[maxBlocks][];
                int numRead;
                int brokenRemaining = nameLength;
                int currentBlock = 0;
                string brokenResult = string.Empty;
                bool isBroken = false;
                progress_Parse.Report(0f);
                while ((numRead = await stream.ReadAsync(bytes, 0, bytes.Length)) != 0) {
                    progress_Writing.Report((float)currentBlock / (float)maxBlocks);
                    bool arrayResized = false;
                    if (bytes.Length != numRead) {
                        Array.Resize(ref bytes, numRead);
                        arrayResized = true;
                    }
                    bool hasChanged = false;
                    if (isBroken) {
                        brokenResult += Encoding.ASCII.GetString(bytes, 0, brokenRemaining);
                        if (CheckString(brokenResult))
                        {
                            Array.Copy(writeDllBytes, brokenRemaining, lastBytes, 0, brokenRemaining);
                            brokenRemaining = nameLength - brokenRemaining;
                            Array.Copy(writeDllBytes, 0, lastBytes, brokenRemaining, brokenRemaining);
                            changedBytes[currentBlock - 1] = lastBytes;
                            hasChanged = true;
                        }
                        isBroken = false;
                    }
                    for (int offset = 0; offset < bytes.Length; offset++) {
                        if (bytes[offset] == literalB) {
                            brokenRemaining = bytes.Length - offset;
                            if (brokenRemaining < nameLength) {
                                isBroken = true;
                                lastBytes = (byte[])bytes.Clone();
                                brokenResult = Encoding.ASCII.GetString(bytes, offset, brokenRemaining);
                                brokenRemaining = nameLength - brokenRemaining;
                                break;
                            }
                            if (CheckString(Encoding.ASCII.GetString(bytes, offset, nameLength))) {
                                Array.Copy(writeDllBytes, 0, bytes, offset, nameLength);
                                hasChanged = true;
                            }
                        }
                    }
                    if (hasChanged) {
                        changedBytes[currentBlock] = (byte[])bytes.Clone();
                    }
                    if (arrayResized) {
                        bytes = new byte[bufferSize];
                    }
                    currentBlock++;
                }

                bool CheckString(string result) {
                    if (string.Equals(result, readDll, StringComparison.Ordinal)) {
                        return true;
                    }
                    return false;
                }

                progress_Writing.Finish();
                // Writing Start
                stream.Seek(0, SeekOrigin.Begin);
                for (currentBlock = 0; currentBlock < changedBytes.Length; currentBlock++) {
                    progress_Parse.Report((float)currentBlock / (float)maxBlocks);
                    bytes = changedBytes[currentBlock];
                    if (bytes == null) {
                        stream.Seek(bufferSize, SeekOrigin.Current);
                        continue;
                    }
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                }

                progress_Parse.Finish();
                stream.Dispose();

                /*
                if (compress) {
                    await Recompress(bundle, progress_Compress);
                    progress_Compress.Finish();
                }
                */
            } catch (Exception ex) {
                throw ex;
            } finally {
                stream.Dispose();
                progress_Writing.Finish();
                progress_Parse.Finish();
                // progress_Compress?.Finish();
            }
        }
        private async Task Recompress(FileInfo bundle, BaseJumper.Editor.Progress.ProgressInstance progress) {
            try {
                var recompress = UnityEngine.AssetBundle.RecompressAssetBundleAsync(bundle.FullName, bundle.FullName, BuildCompression.LZ4Runtime);
                await RecompressionTask(recompress, progress);
            } catch (Exception ex) {
                Debug.LogException(ex);
            } finally {
                progress.Finish();
            }
        }

        private async Task RecompressionTask(AssetBundleRecompressOperation recompress, BaseJumper.Editor.Progress.ProgressInstance progress) {
            if (!recompress.isDone) {
                progress.ProgressGetter += (_) => recompress.progress;
                progress.Update();
                var completionSource = new TaskCompletionSource<AsyncOperation>();
                recompress.completed += completionSource.SetResult;
                recompress.completed += (_) => progress.Finish();
                await completionSource.Task;
            }
        }
    }
    public sealed class SpecialLogger : AssetStudio.ILogger {
        static string[] NamesToIgnore => new string[] {
            "unity default resources",
            "unity_builtin_extra",
        };
        public void Log(LoggerEvent loggerEvent, string message) {
            switch (loggerEvent) {
				case LoggerEvent.Info:
				case LoggerEvent.Verbose:
				case LoggerEvent.Debug:
					// Debug.Log(message);
					break;
				case LoggerEvent.Warning:
                    if (NamesToIgnore.Any(message.EndsWith)) {
                        break;
                    }
					Debug.LogWarning(message);
					break;
				case LoggerEvent.Error:
					Debug.LogError(message);
					break;
			}
        }
    }
}