using System;
using System.Reflection;
using System.IO;
using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEngine;

namespace Unity.Editor.LoRDeps {
    static class LoR_Dependencies
    {
        static readonly FileInfo installedFlag = new FileInfo(Application.dataPath+"/BaseJumper_Core/Editor/DepsDownloaded");
        static AddRequest Request;
        static readonly string[] packageList = new string[] {
            "com.unity.textmeshpro",
            "com.unity.mathematics",
            "com.unity.postprocessing",
        };
        static int currentPackage = 0;

        [InitializeOnLoadMethod]
        static void AutoAdd() {
            if (!installedFlag.Exists) {
                Add();
            }
        }

        [MenuItem("BaseJumper/Force Dependency Download")]
        static void ForceAdd() {
            Add();
        }
        
        static void Add()
        {
            ClearConsole();
            // Add a package to the project
            Request = Client.Add(packageList[currentPackage]);
            // EditorApplication.update += Progress;
            while (currentPackage < packageList.Length) {
                while (!Request.IsCompleted) {}
                Progress();
            }
            currentPackage = 0;
            if (!installedFlag.Exists) {
                installedFlag.Create();
            }
        }

        static void Progress()
        {
            if (Request.Status == StatusCode.Success)
                Debug.Log("Installed: " + Request.Result.packageId);
            else if (Request.Status >= StatusCode.Failure)
                Debug.LogWarning(Request.Error.message);

            if (++currentPackage == packageList.Length) {
                // EditorApplication.update -= Progress;
                // currentPackage = 0;
                return;
            }
            Request = Client.Add(packageList[currentPackage]);
        }
        private static void ClearConsole()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(SceneView));
            Type type = assembly.GetType("UnityEditor.LogEntries");
            MethodInfo method = type.GetMethod("Clear");
            method.Invoke(new object(), null);
        }
    }
}