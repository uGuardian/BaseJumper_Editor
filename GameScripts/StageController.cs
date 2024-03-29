﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class StageController : Singleton<StageController>
{
	private StageModel _stageModel;

	private StageType _stageType;

	private SephirahType _prevDefeatFloor;

	private SephirahType _currentFloor;

	private int _currentWave;

	private int _roundTurn;

	private BattleRewardInfo _rewardInfo;

	private BattleTeamModel _librarianTeam;

	private BattleTeamModel _enemyTeam;

	private EnemyUnitAggroSetter _aggroSetter;

	private EnemyTeamStageManager _enemyStageManager;

	private bool _mapChanged;

	private bool _mapChangedByAssimilation;

	private StageController.StageMapState _stageMapState;

	private StageController.StageState _state;

	public StageController.OnChangePhaseDelegate onChangePhase;

	private StageController.StagePhase _phase;

	public bool dontUseUILog;

	private float _skipTurnElapsed;

	private bool _roundendedforcely;

	private bool _bRoundStarted;

	private bool _bCalledRoundStart_system;

	public List<DropBookDataForAddedReward> _droppedbookdatas;

	private List<LorId> _usedBooks;

	private List<SephirahType> _usedFloorList;

	public StageController.BattleState battleState;

	private int _noCardRoundCount;

	public bool firstStartState;

	private float _elapsedTimeTeleport;

	private BattleUnitModel _teleportEffectTarget;

	private bool _forceFloorChange;

	private SephirahType _forceFloorChangeSephirah;

	private List<AchievementEnum> _reservedAchievements;

	private List<AchievementEnum> _processedAchievements;

	public StageWaveHistory waveHistory;

	private List<string> _addedEgoMap;

	private bool _reviveReserve;

	private bool _alreadyStory;

	private bool _isEndContentsStage;

	private bool _isEndContentByInv;

	private bool _isRebattle;

	public static bool[] toggleState;

	private Direction _allyFormationDirection;

	public bool killTwistedArgalia;

	public bool rolandLastAtk;

	public bool argaliaFinalMapChanged;

	private bool _bFirstInputEntered;

	private float _inputDelay;

	private float _mapChangeTimer;

	private List<StageController.ParryingCards> _parryingList;

	private List<BattlePlayingCardDataInUnitModel> _oneSideList;

	private List<BattlePlayingCardDataInUnitModel> _allCardList;

	private List<StageController.AddedCardSet> _addedCardList;

	private List<StartBattleEffect> _startBattleEffectList;

	private const int _speedMaxValue = 10;

	private int _roundEndDetailPhase;

	private float _waitStartReturnUnit;

	public List<FinalRewardCardInfo> rewardcardlist;

	private BattleUnitModel unitEnemy;

	private BattleUnitModel unitLibrarian;

	private int unitKpA;

	private int unitKpB;

	private float elapsedEndOneSide;

	private BattleUnitModel attacker;

	private BattleUnitModel victim;

	private int _timeLevel;

	public StageType stageType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public SephirahType prevDefeatFloor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public SephirahType CurrentFloor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int CurrentWave
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int RoundTurn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public EnemyTeamStageManager EnemyStageManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public StageController.StageState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private StageController.StagePhase phase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	public StageController.StagePhase Phase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<LorId> UsedBooks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<SephirahType> usedFloorList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsEndContents
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsEndContentByInv
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsRebattle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitCommon(StageClassInfo stage, bool isRebattle)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStageByInvitation(StageClassInfo stage, List<LorId> books = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStageByEndContentsStage(StageClassInfo stage, bool inv = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStageForKeterCompleteOpen(StageClassInfo stage, bool isRebattle = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStageByCreature(StageClassInfo stage, bool isRebattle = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageModel GetStageModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentSephirah(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentWave(int waveLevel)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageWaveModel GetCurrentWaveModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageLibraryFloorModel GetCurrentStageFloorModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearResources()
	{
		
	}

	public Direction AllyFormationDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckOpenManual()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateBattleUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel AddNewUnit(Faction faction, int enemyUnitId, int index, int height = -1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel AddNewUnit(Faction faction, LorId enemyUnitId, int index, int height = -1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveUnit(Faction faction, int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReservePlayerRevive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RevivePlayerCharacters()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckEndBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseBattleScene()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckStoryBeforeBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckStoryAfterBattle(bool isWin)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckStoryBeforeRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ContinueStory_2()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ContinueStory_3()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ContinueStory_4()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndTwistedArgaliaBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillAllEnemy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillAllLibrarian()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAutoCardForNonControlablePlayer()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAutoCardForPlayer()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCardAryEmpty()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnequipCardAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUpdate(float deltatTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckInput(bool forcelyInput)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SkipRoundStartUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopSpeedDiceRoll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CompleteApplyingLibrarianCardPhase(bool auto = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdate(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdateLate(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearLibrarianUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateLibrarianUnit(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel CreateLibrarianUnit_fromBattleUnitData(int unitIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel CreateLibrarianUnit(SephirahType sephirah, UnitBattleDataModel battleData, int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateEnemyUnitByWave(StageWaveModel wave)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleUnitModel CreateEnemyUnit(UnitBattleDataModel unitBattleData, int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RoundStartPhase_UI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RoundStartPhase_System()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckMapChange()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawCardPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SortUnitPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WaitPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetActionableEnemyList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyEnemyCardPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyLibrarianCardPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyEnemyCardAuto(BattleUnitModel unit, int currentSpeedDiceIdx, int speed)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyPlayerCardAuto(BattleUnitModel unit, int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnEquipPlayerCard(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckChangeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeMapPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ArrangeCardsPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActivateStartBattleEffectPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterStartBattleEffect(StartBattleEffect effect)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WaitStartBattleEffectPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCurrentDiceActionPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckFarAreaPlayPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteFarAreaPlayPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndFarAreaPlayPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndFarAreaPlay(BattleUnitModel attacker, List<BattlePlayingCardDataInUnitModel> victimsCards)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveUnitPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WaitUnitArrivePhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RoundEndPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool RoundEndPhase_ExpandMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool RoundEndPhase_ReturnUnit(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool RoundEndPhase_ChoiceEmotionCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool RoundEndPhase_TheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool RoundEndPhase_WaitForEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RoundEndPhase_CheckNoCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool NoCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BattleStoryPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TeleportPurpleTear(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndBattlePhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndBattlePhaseAfter(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndBattlePhase_invitation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BonusRewardWithPopup(LorId stageId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndBattlePhase_creature()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GameOver(bool iswin, bool isbackbutton = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveUsedCardData(BattlePlayingCardDataInUnitModel cardData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sp(BattlePlayingCardDataInUnitModel cardA, BattlePlayingCardDataInUnitModel cardB)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartParrying(BattlePlayingCardDataInUnitModel cardA, BattlePlayingCardDataInUnitModel cardB)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndParrying(BattleUnitModel unitEnemy, BattleUnitModel unitLibrarian, int kpA, int kpB)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndParryingPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartAction(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOneSideAction(BattleUnitModel attacker, BattleUnitModel victim, int kp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndOneSideActionPhase(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessViewActionByResultPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnemyDropBookForAdded(DropBookDataForAddedReward data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DropBookDataForAddedReward[] GetDroppedBooksData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLogState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHideEnemyDiceAbilityInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBlockEnemyAggroChange()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsVisibleEnemyTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RoundEndForcely()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BattleEndForcelyNotRound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyAddedCardList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAllCardListInBattle(BattlePlayingCardDataInUnitModel card, BattleUnitModel target, int slot = -1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattlePlayingCardDataInUnitModel> GetAllCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveUnusedCards()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEgoMapByAssimilation(string name)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanChangeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTwistedArgaliaBattleEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsKeterFinalBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRoland4thBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PrintFinalEndUI(bool playerWin)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEgoMapAll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEgoMapByAssimilation(string name)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFloorForcely(SephirahType sephirah, BattleUnitModel teleportUnit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnlockAchievement(AchievementEnum achievement)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReserveAchievement(AchievementEnum achievement)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessAchievements()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckClearForAchievement(LorId stageId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanChangeTimeLevel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTimeLevel(int timeLevel)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageController()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StageController()
	{
		throw null;
	}

	public enum StageState
	{
		None,
		Battle
	}

	public enum StagePhase
	{
		RoundStartPhase_UI,
		RoundStartPhase_System,
		DrawCardPhase,
		SortUnitPhase,
		ApplyEnemyCardPhase,
		ApplyLibrarianCardPhase,
		PeekFirstTurnUnitPhase,
		ExecuteParrying,
		EndParrying,
		RoundEndPhase,
		RoundEndPhase_two,
		ExecuteUnitsActionPhase,
		ChangeMapPhase,
		ArrangeEquippedCards,
		ActivateStartBattleEffect,
		WaitStartBattleEffect,
		SetCurrentDiceAction,
		CheckFarAreaPlay,
		ExecuteFarAreaPlay,
		EndFarAreaPlay,
		CheckParrying,
		MoveUnits,
		WaitUnitsArrive,
		CheckOneSideAction,
		ExecuteOneSideAction,
		EndOneSideAction,
		ProcessViewAction,
		BattleStoryPhase,
		EndBattle,
		EndBattle2,
		TeleportPurpleTear
	}

	public enum StageMapState
	{
		Librarian,
		Enemy
	}

	public delegate void OnChangePhaseDelegate(StageController.StagePhase prevPhase, StageController.StagePhase nextPhase);

	public enum BattleState
	{
		None,
		Battle,
		Setting
	}

	private struct ParryingCards
	{
		internal BattlePlayingCardDataInUnitModel cardA;

		internal BattlePlayingCardDataInUnitModel cardB;
	}

	private class AddedCardSet
	{
		public BattlePlayingCardDataInUnitModel card;

		public BattleUnitModel target;

		public int targetSlot;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddedCardSet()
		{
			
		}
	}
}
