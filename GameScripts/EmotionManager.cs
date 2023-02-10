using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmotionManager : MonoBehaviour
{
	private static EmotionManager _instance;

	public List<GameObject> emotionPrefabList;

	public List<string> EmotionList;

	public static EmotionManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateEmotions(string emotionStr, string posStr, Vector3 facePos, float xError)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetEmotionPos(string posStr, Vector3 vec, float xerror)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Quaternion GetEmotionRot(string posStr)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionManager()
	{
		throw null;
	}
}
