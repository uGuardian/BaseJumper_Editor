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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnApplicationQuit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReloadOptionData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadStaticData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadSavedGlobalData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadSavedLocalData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InitGameData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ContinueGame(int slot, Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckSaveData(int slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnterInvitation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowPrologueStory(int ep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleScene()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOption(OptionDataModel data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleResultScene(StageClassInfo stageInfo)
	{
		throw null;
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator UnloadRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restart()
	{
		throw null;
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
