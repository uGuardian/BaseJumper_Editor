using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AssetBundleManagerRemake : Singleton<AssetBundleManagerRemake>
{
	private AssetBundle _cardAssetBundle;

	private Dictionary<string, AssetBundleManagerRemake.AssetResourceCacheData> _characterResourceCache;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadAllCharacterCache()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetAssetPath(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetCharacterResourcePath(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadCardAssetBundle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite LoadCardSprite(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject GetSdResourceObject(string resourceName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseSdObject(string resourceName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject LoadSdPrefab(string resourceNAme)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject LoadCharacterPrefab(string charName, string s, out string resourceName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject LoadCharacterPrefab_DefaultMotion(string charName, string s, out string resName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject LoadCharacterPrefab_DefaultMotion_Nullable(string charName, string s, out string resName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AssetBundleManagerRemake()
	{
		throw null;
	}

	public class AssetResourceCacheData
	{
		public AssetBundle asset;

		public string name;

		public GameObject resObject;

		public int refCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AssetResourceCacheData()
		{
			throw null;
		}
	}
}
