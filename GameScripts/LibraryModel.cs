using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class LibraryModel
{
	public const string save_inventory = "inventory";

	public const string save_bookInventory = "bookInventory";

	public const string save_CustomCorebookInventory = "CustomCorebookInventory";

	public const string save_deckList = "deckList";

	public const string save_usingBookInventory = "usingBookInventory";

	public const string save_clearInfo = "clearInfo";

	public const string save_customStorage = "customStorage";

	public const string save_openedSephirah = "openedSephirah";

	public const string save_floorList = "floorList";

	public const string save_playHistory = "playHistory";

	public const string save_dropBox = "dropBox";

	public const string save_storySee = "storySee";

	private static LibraryModel _instance;

	private StageClearInfoListModel _clearInfo;

	private PlayHistoryModel _playHistory;

	private List<string> _storySeeInfo;

	private int _currentChapter;

	private List<LibraryFloorModel> _floorList;

	private HashSet<SephirahType> _openedSephirah;

	private HashSet<int> _openedChapterPrologue;

	private CustomSaveStorageModel _customStorage;

	private int[] chapterupNeedLevel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LibraryModel()
	{
		throw null;
	}

	public static LibraryModel Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public StageClearInfoListModel ClearInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PlayHistoryModel PlayHistory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CustomSaveStorageModel CustomStorage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NewGame()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddFloor(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLibraryLevel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetChapter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenSephirah(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOpenedSephirah(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookModel> GetEquipedBookList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SephirahType CheckOpenSephirah()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SephirahType CanOpenSephirah(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckLibraryChapterUp()
	{
		throw null;
	}

	public int[] Chapterupneedlevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanLibraryOpenNextChapterStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanLevelUpSephirah(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckSephirahCompleteOpen(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckCreatureBossBattle(LibraryFloorModel floor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckOpenComplete(LibraryFloorModel floor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckOpenCompleteForAngela()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckOpenCompleteForRoland()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanReleaseNewStoryFloorByLevel(LibraryFloorModel floor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetOpenStoryNumberByFloor(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLibraryChapterStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSephirahChapterStory(LibraryFloorModel floor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<LibraryFloorModel> GetOpenedFloorList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<SephirahType> GetOpenedSephirahList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<SephirahType> GetOpenedAndOpenableSephirahList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LibraryFloorModel GetFloor(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SephirahType GetSephirahByUnit(UnitDataModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClearStage(LorId stageId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUnlocked(SephirahType sephirah, ContentLock lockType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBinahLockedInLibrary()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBlackSilenceLockedInLibrary()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBinahLockedInStage(StageClassInfo stageInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBlackSilenceLockedInStage(StageClassInfo stageInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStorySeeInfo(int chapter, int group, int episode, bool save = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddStorySeeInfo(string storyId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AlreadySeeStory(int chapter, int group, int episode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AlreadySeeStory(string storyId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEpNumberTalkStory(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanPassiveSuccession()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsClearTheBlueReverberationPrimary(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsClearTheBlueReverberationPrimaryFloor(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAllClearBluePrimaryWithoutKeter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAllClearBluePrimary()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UI_BluePrimaryBattleState GetBattleStateForBluePirmary()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UI_BluePrimaryFloorState GetFloorStateForBlueBrimary(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBlueClearMidway()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsClearForEndContentsStage(EndContentsStageId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIEndContentsState GetEndContentState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetKeterCompleteOpenPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsKeterCompleteOpen(LibraryFloorModel floor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsClearRats()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsClearYuns()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAchievement()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAllEquips()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAllCards()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckManyGifts()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckSmallStory()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckNormalInvitation()
	{
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static LibraryModel()
	{
		throw null;
	}
}
