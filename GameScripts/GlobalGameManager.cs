using System;
using System.Collections;
using System.Runtime.CompilerServices;
using SteamAPI;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGameManager : MonoBehaviour
{
	private static GlobalGameManager _instance;

	public static bool WithMods;

	private bool _initialized;

	private bool _gamePlayInitialized;

	public GlobalGameManager.StagecraftMode stagecraftMode;

	private OptionDataModel _optionModel;

	private SteamAPI.SteamAPI _api;

	[NonSerialized]
	public string ver;

	[NonSerialized]
	public bool isOnlyBattleMode;

	private GlobalGameManager.NextUI _nextUI;

	private StageClassInfo _stageInfo;

	[Header("Debug")]
	public Text debug_txt_fps;

	private bool _asyncLock;

	public static GlobalGameManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool Initalized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool GamePlayInitialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public OptionDataModel CurrentOption
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalGameManager.NextUI GetNextUI()
	{
		throw null;
	}

	public StageClassInfo CurrentStageInfo
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
	public void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnApplicationQuit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReloadOptionData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadStaticData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadSavedGlobalData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadSavedLocalData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InitGameData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ContinueGame(int slot, Action<bool> callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckSaveData(int slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnterInvitation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowPrologueStory(int ep)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleScene()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOption(OptionDataModel data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleResultScene(StageClassInfo stageInfo)
	{
		
	}

	public bool asyncLock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadResourcesAsync()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator UnloadRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalGameManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalGameManager()
	{
		throw null;
	}

	public enum NextUI
	{
		Main,
		BattleResult
	}

	public enum StagecraftMode
	{
		Detail,
		Simple
	}
}
