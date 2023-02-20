using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
	private static PlatformManager _instance;

	[SerializeField]
	private GameObject _iconRoot;

	private Dictionary<int, SaveData> _preloadedData;

	private PlatformCore _core;

	private bool _initialized;

	private LOR_Platform _platformType;

	private string _gamerTag;

	private int _loadingCount;

	public static PlatformManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsProccessing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool initialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public LOR_Platform PlatformType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlatformManager.CallbackSignInDel callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetPreloadedData(int slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReInitialize(PlatformManager.CallbackSignInDel callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SavePlayData(int slot, SaveData savedata)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadPlayData(int slot, Action<SaveData> callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistsSaveData_slot1()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveData(string name, SaveData savedata)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadData(string name, Action<SaveData> callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTheLastAchievment()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AchievementUnlocked(AchievementEnum achievement)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnlockAchievement(AchievementEnum achievement)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAllAchievements()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLanguageFromPlatform()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnApplicationQuit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearResource()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetWorkshopDirPath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddLoadingCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SubLoadingCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeTag(string tag)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGamerTag()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlatformManager()
	{
		throw null;
	}

	public delegate void CallbackSaveDel(bool success);

	public delegate void CallbackLoadDel(bool success, SaveData data);

	public delegate void CallbackSignInDel(bool success);
}
