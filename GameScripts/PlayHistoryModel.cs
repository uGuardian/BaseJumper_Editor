using System;
using System.Runtime.CompilerServices;
using GameSave;

public class PlayHistoryModel : Savable
{
	public const string save_feedBookCount = "feedBookCount";

	public const string save_furiosoKill1 = "furi1";

	public const string save_furiosoKill2 = "furi2";

	public const string save_Clear_EndcontentsAllStage = "Clear_EndcontentsAllStage";

	public int prologueOpenInvtationManual;

	public int tutorialInteractUI_HighlightedInvitaionButton;

	public int tutorial_EnterBattleSetting;

	public int tutorial_EnterBattleResult;

	public int tutorial_keterOpenbyratsClear;

	public int tutorial_EnterUIScene;

	public int tutorial_FloorFeedBookButtonClick;

	public int tutorial_SelectOneBook;

	public int tutorial_FloorFeedBookFirstClick;

	public int tutorial_EnterResultFloorFeedBook;

	public int tutorial_SelectLibrarianSlot;

	public int tutorial_EnterBattlePagePanel;

	public int tutorial_EnterEquipPagePanel;

	public int tutorial_EnterLibrarianInfo;

	public int tutorial_EnterCustomizeButton;

	public int tutorial_EnterStoryArchives;

	public int tutorial_firstCreatureBattleStart;

	public int tutorial_EnterUISceneAfterYunOffice;

	public int tutorial_EnterBattleSettingAfterYunOfficeWaveClear;

	public int tutorial_PossibleFloorAlarm;

	public int tutorial_EnterInvtationAfterHookOffice;

	public int tutorial_OpenPassiveSuccessionAlarm;

	public int tutorial_NightmareCostUpPassiveSuccessionAlarm;

	public int tutorial_StarCostUpPassiveSuccessionAlarm;

	public int tutorial_ImpurityCostUpPassiveSuccessionAlarm;

	public int tutorial_CostUpPassiveSuccessionAlarm;

	public int tutorial_EnterBattle;

	public int tutorial_EnterBattleSpaceDice;

	public int tutorial_CharacterEmotionCoinManual;

	public int tutorial_FirstRevealCardRangeManual;

	public int tutorial_PossibleEmotionCard;

	public int tutorial_EnterBattlePuppet;

	public int tutorial_FirstRevealWideCard;

	public int tutorial_FirstRevealEgoCard;

	public int tutorial_EnterBattle_StartBattleTutorial;

	public int tutorial_EnemyUnit_Break;

	public int tutorial_EnemyUnit_Dead;

	public int tutorial_CreatureBattle_StartTutorial;

	public int tutorial_Alarm_CanUsebinahInMain;

	public int tutorial_Alarm_CanUseBlackSilence;

	public int currentclearStoryid;

	public int currentchapterLevel;

	public int Tutorial_GetFirstCoreBook;

	public int first_creaturebattle;

	public int Start_TheBlueReverberationPrimaryBattle;

	public int Start_EndContents;

	public int Clear_TwistedBluePrevUpdate;

	public int Clear_EndcontentsAllStage;

	public int first_TheBluePrimary_keterXmark;

	public int first_ThrBluePrimary_RewardAlarm;

	public int story_BlackSilence_progress;

	public int alarm_midway;

	public int ResetSecondRewardClearEndContents;

	public int testcount;

	public int blueprimarytestcount;

	public float playtime;

	public int feedBookCount;

	public int furiosoKill1;

	public int furiosoKill2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResetCompleteOpen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllClear()
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayHistoryModel()
	{
		throw null;
	}
}
