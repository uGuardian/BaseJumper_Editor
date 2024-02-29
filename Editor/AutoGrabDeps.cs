using System;
using System.Reflection;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEngine;

namespace Unity.Editor.LoRDeps {
    static class AutoGrabDeps {
        static string[] DownloadRecord {
            get {
                return EditorPrefs.GetString("BaseJumper_Dependency_Record").Split('\0');
            }
            set {
                EditorPrefs.SetString("BaseJumper_Dependency_Record", string.Join("\0", value));
            }
        }
        static AddRequest[] requests;
        const string spineUrl = "https://github.com/uGuardian/spine-runtimes.git?path=spine-unity/Assets/Spine#3.8UPM";
        static readonly string[] packageList = new string[] {
            spineUrl,
        };

        [InitializeOnLoadMethod]
        public static void AutoAdd() => Add(packageList.Where(x => !DownloadRecord.Contains(x)).ToArray());

        [MenuItem("BaseJumper/Debug/Force Download/All packages")]
        public static void AddAll() => Add(packageList);

        [MenuItem("BaseJumper/Debug/Force Download/Spine 3.8")]
        public static void AddSpine() => Add(spineUrl);

        static void Add(params string[] targets) {
            int length = targets.Length;
            ClearConsole();
            requests = new AddRequest[length];
            // Add a package to the project
            for (int i = 0; i < length; i++) {
                requests[i] = Client.Add(targets[i]);
            }
            // EditorApplication.update += Progress;
            bool[] completed = new bool[length];
            int completedCount = 0;
            while (completedCount < length) {
                for (int i = 0; i < requests.Length; i++) {
                    AddRequest request = requests[i];
                    if (completed[i]) {continue;}
                    bool check = ProgressCheck(request);
                    completed[i] = check;
                    if (check) {completedCount += 1;}
                }
                if (completedCount >= length) {break;}
            }
        }

        static bool ProgressCheck(AddRequest request) {
            switch (request.Status) {
                case StatusCode.InProgress:
                    return false;
                case StatusCode.Success:
                    Debug.Log("Installed: " + request.Result.packageId);
                    return true;
                case StatusCode.Failure:
                    Debug.LogWarning(request.Error.message);
                    return true;
                default:
                    throw new InvalidOperationException("Invalid Status Code");
            }
        }
        private static void ClearConsole() {
            Assembly assembly = Assembly.GetAssembly(typeof(SceneView));
            Type type = assembly.GetType("UnityEditor.LogEntries");
            MethodInfo method = type.GetMethod("Clear");
            method.Invoke(new object(), null);
        }
    }
}