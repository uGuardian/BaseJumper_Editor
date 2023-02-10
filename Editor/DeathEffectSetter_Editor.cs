using UnityEngine;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

[CustomEditor(typeof(DeathEffectSetter))]
public class DeathEffectSetter_Editor : Editor, IPreprocessBuildWithReport
{
	public int callbackOrder => 0;

	override public void OnInspectorGUI()
    {
        var script = target as DeathEffectSetter;

        script.overridePlayer = GUILayout.Toggle(script.overridePlayer, "overridePlayer");
        script.overrideEnemy = GUILayout.Toggle(script.overrideEnemy, "overrideEnemy");
    
        script.isVanillaEffect = GUILayout.Toggle(script.isVanillaEffect, "isVanillaEffect");
        
        if (script.isVanillaEffect) {
            script.vanillaEffect = EditorGUILayout.TextField("Vanilla Effect Path", script.vanillaEffect);
        } else {
            script.effect = EditorGUILayout.ObjectField(script.effect, typeof(CharacterDeadEffect), false) as CharacterDeadEffect;
        }
        GUIUtility.ExitGUI();
    }

	public void OnPreprocessBuild(BuildReport report)
	{
		var script = target as DeathEffectSetter;

        if (script.isVanillaEffect) {
            script.effect = null;
        } else {
            script.vanillaEffect = null;
        }
	}
}