using System;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace BaseJumper.Editor {
	public partial class BaseJumper_Editor : EditorWindow {
		[MenuItem("BaseJumper/Settings")]
		static void OpenWindow_Static() {
			LocationString = EditorPrefs.GetString("LoR_Location", defaultLoc);
			Window.Show();
		}
		[SerializeField]
		public static string LocationString {
			get {
				return locationString ?? EditorPrefs.GetString("LoR_Location", defaultLoc);
			}
			set {
				if (locationString == null) {
					locationString = defaultLoc;
				}
				if (!locationString.Equals(value, StringComparison.Ordinal)) {
					if (VerifyLocation(ref value)) {
						locationString = value;
						EditorPrefs.SetString("LoR_Location", value);
					}
				}
			}
		}
		static string locationString;
		public static DirectoryInfo Location => new DirectoryInfo(LocationString);
		static readonly string defaultLoc = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Library Of Ruina";
		void OnGUI () {
			LocationString = EditorGUILayout.TextField("LoR Path: ", LocationString);
			this.Repaint();
		}
		public static bool VerifyLocation(ref string loc) {
			try {
				var dir = new DirectoryInfo(loc);
				if (dir.Exists) {
					var files = dir.EnumerateFiles("LibraryOfRuina.exe");
					if (files.Any()) {
						loc = dir.FullName;
						return true;
					}
				}
				return false;
			} catch (ArgumentException) {
				return false;
			}
		}
		public static bool VerifyLocation() => VerifyLocation(ref locationString);
	}
}