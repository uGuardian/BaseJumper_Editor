using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

[Serializable]
public class BattleUnitModel : BattleUnitBaseModel
{
	public BattleCardTotalResult battleCardResultLog;

	public bool isRegister;

	private int _id;

	private UnitBattleDataModel _unitData;

	public int index;

	public BattleUnitView view;

	private BattleTeamModel _team;

	public Faction faction;

	public BattleUnitModelEquip equipment;

	public bool stopped;

	public int currentSpeedDiceIdx;

	public List<SpeedDice> speedDiceResult;

	public BattlePlayingCardDataInUnitModel currentDiceAction;

	public BattleUnitTurnState turnState;

	public FormationPosition formation;

	private float _timeScale;

	public HexagonalTileMover moveDetail;

	public BattleUnitBreakDetail breakDetail;

	public bool disposed;

	public UnitBattleDataHistory history;

	public BattleUnitCardHistoryDetail cardHistory;

	private List<BattleUnitBuf> _connectedBufs;

	public bool isTauntable;

	public bool forceRetreat;

	public bool ignoreBloodyEffect;

	public EnemyUnitTargetSetter targetSetter;

	public BattleUnitAggroDetail aggroDetail;

	public Direction direction;

	[NonSerialized]
	public BattleUnitModel lastAttacker;

	public BattlePlayingCardSlotDetail cardSlotDetail;

	public BattleUnitBufListDetail bufListDetail;

	public BattleAllyCardDetail allyCardDetail;

	public BattleAllyCardDetail savedCardDetail;

	public BattlePersonalEgoCardDetail personalEgoDetail;

	public BattleUnitPassiveDetail passiveDetail;

	public int cardOrder;

	private bool _deadSceneBlock;

	private bool _bActionable;

	private bool _periodPlCheck;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel(int id)
	{
		throw null;
	}

	public int id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public UnitBattleDataModel UnitData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleTeamModel Team
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

	public BookModel Book
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BookModel customBook
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int PlayPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int MaxPlayPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float hp
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public int speedDiceCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpeedDice GetSpeedDiceResult(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpeedDiceValueAdder(int index, int adder)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllSpeedDiceValueAdder(int adder)
	{
		
	}

	public int MaxBreakLife
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Vector3Int formationCellPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int MaxHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHp(int newHp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageIncreaseRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageIncreaseRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetDamageRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetBreakDamageRate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float BreakDmgFactor(int dmg, DamageType type = DamageType.ETC, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmuneBreakDmg(DamageType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmuneDmg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsImmortal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsStraighten()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMinHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBreakDamageReductionAll(int dmg, DamageType dmgType, BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDamageReductionAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTakenGuardBreakDamageAdder(int dmg)
	{
		throw null;
	}

	public BattleUnitEmotionDetail emotionDetail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowTypoTemporary(BattleEmotionCardModel emotionPassive, int index, ResultOption option = ResultOption.Default, params int[] param)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowPassiveTypo(PassiveAbilityBase passive)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetFixedTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<SpeedDice> RollSpeedDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRole()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetTurn()
	{
		
	}

	public bool IsDeadSceneBlock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentOrder(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetSpeed(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTauntable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentSpeed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAttackable(BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanChangeAttackTarget(BattleUnitModel target, int myIndex = 0, int targetIndex = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AllowTargetChanging(BattleUnitModel attacker, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ChangeTargetSlot(BattleDiceCardModel card, BattleUnitModel target, int currentSlot, int targetSlot, bool teamkill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnitData(UnitBattleDataModel unitBattleData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateUnitData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeadSceneBlock(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeBaseDeck(List<DiceCardXmlInfo> cardList, int drawNum)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeTemporaryDeck(List<LorId> cardIdList, int drawNum)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnToOriginalDeck()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDeck(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetable(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsTargetable_theLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTargetableUnit(BattleDiceCardModel card, BattleUnitModel actor, BattleUnitModel target, int targetDiceIdx = -1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActionable(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActionable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsControlable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCardChoosable(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_before()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_ignoreDead()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_after()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart_speedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStartOnlyUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd_before()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEndTheLast_ignoreDead()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd_after()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndParrying_Before(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOneSideAction_Before(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattle(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOnSideActionVictim_Before(BattlePlayingCardDataInUnitModel attackerCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndOneSideAction(bool wasAttacker)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndFarAreaPlay()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpendCardAndCost(BattleDiceCardModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroyCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnParryingStart(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGiftOnParryingStart(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnemyRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterDiceAction(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSucceedAreaAttack(BattleDiceBehavior behavior, BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGiftOnWinParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGiftOnLoseParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawParrying(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDiscardByAbility(List<BattleDiceCardModel> cards)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnAddKeywordBufByCard(BattleUnitBuf buf, int stack)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAddKeywordBufByCardForEvent(KeywordBuf bufType, int stack, BufReadyType readyType)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int OnGiveKeywordBufByCard(BattleUnitBuf buf, int stack, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMultiplierOnGiveKeywordBufByCard(BattleUnitBuf buf, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDieOtherUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGiftOnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTakeBreakDamageByAttack(BattleDiceBehavior atkDice, int breakdmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterTakeDamage(BattleUnitModel attacker, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterGiveDamage(BattleUnitModel target, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeLoseHPNotDmg(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseHp(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool BeforeTakeBreakDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartCardAction(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartOneSideAction(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartTargetedByAreaAtk(BattlePlayingCardDataInUnitModel attackerCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMakeBreakState(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnBreakGageZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBreakState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnReleaseBreak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdateInWaitPhase(float delta)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnKill(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnHpZero()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGiftOnKill(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckCardAvailable(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPriority(BattleDiceCardModel card, int speed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckCardAvailableForPlayer(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnApplyCard(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGainChargeStack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseChargeStack()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTimeScale(float timeScale)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecoverHP(int v)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRecoverHp(int recoverAmount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRecoverBreak(int recoverAmount)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRecoverHp(int recoverAmount)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecoverBreakLife(int v, bool ignore = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvincibleHp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvincibleBp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int TakeDamage(int v, DamageType type = DamageType.Attack, BattleUnitModel attacker = null, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGiftOnTakeDamage(int dmg, DamageType type, BattleUnitModel attacker, KeywordBuf keyword)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int LoseHp(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Revive(int recoverHp)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Extinct(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DieFake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Die(BattleUnitModel attacker = null, bool callEvent = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDie(bool callEvent = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConnectBuf(BattleUnitBuf buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBreakLifeZero()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetBreakGauge()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TakeBreakDamage(int damage, DamageType type = DamageType.Attack, BattleUnitModel attacker = null, AtkResist atkResist = AtkResist.Normal, KeywordBuf keyword = KeywordBuf.None)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDirection(Vector3 targetPos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnFixedUpdate(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCapturedAsTarget(BattleUnitModel attacker)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLayerChanged(string layerName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRollDiceInRecounter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBattleEnd_alive()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBattleEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnOtherUnitReservedCostChanged(BattleUnitModel unit, int cur)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartBattle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel OnSelectCardAuto(BattleDiceCardModel origin, int currentDiceSlotIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DirectAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double ChangeDamage(BattleUnitModel attacker, double dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TeamKill()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNullifyPower()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHalfPower()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int MaxPlayPointAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCheckEndBattle(ref bool librarianExists, ref bool enemyExists)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AtkResist GetResistHP(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AtkResist GetResistBP(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetResistHP_Text(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetResistBP_Text(BehaviourDetail detail)
	{
		throw null;
	}
}
