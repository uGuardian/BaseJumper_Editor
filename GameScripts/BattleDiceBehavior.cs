using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

public class BattleDiceBehavior
{
	public DiceBehaviour behaviourInCard;

	public List<DiceCardAbilityBase> abilityList = new List<DiceCardAbilityBase>();

	public BattlePlayingCardDataInUnitModel card;

	public bool isBonusEvasion;

	public bool isBonusAttack;

	public bool winAgainstFarAtk;

	public bool isUsed;

	public bool forbiddenBonusDice;

	protected int _diceResultValue;

	protected int _damageReductionByGuard;

	protected bool _isParrying;

	protected BattleDiceBehavior _targetDice;

	protected bool _ignoreKnockback;

	protected bool _diceDestroyed;

	private int _diceFinalResultValue;

	private bool _isBlocked;

	private int _diceResultDamage;

	private int _diceDamageAll;

	public DiceUITiming destroyedTiming;

	public bool breakState;

	public bool passingEvasion;

	private DiceStatBonus _statBonus = new DiceStatBonus();

	private DiceStatBonus _firstStatBonus;

	public List<DiceFlag> _flags = new List<DiceFlag>();

	private List<BattleUnitModel> _aliveOpponentList = new List<BattleUnitModel>();

	private int _index;

	private DiceEffectType _effectType = DiceEffectType.None;

	public BattleUnitModel owner
	{
		get
		{
			return this.card.owner;
		}
	}

	public BehaviourType Type
	{
		get
		{
			return this.behaviourInCard.Type;
		}
	}

	public BehaviourDetail Detail
	{
		get
		{
			return this.behaviourInCard.Detail;
		}
	}

	public int DiceResultValue
	{
		get
		{
			return this._diceFinalResultValue;
		}
	}

	public int DiceVanillaValue
	{
		get
		{
			return this._diceResultValue;
		}
	}

	public bool DiceDestroyed
	{
		get
		{
			return this._diceDestroyed;
		}
	}

	public int DiceResultDamage
	{
		get
		{
			return this._diceResultDamage;
		}
	}

	public BattleDiceBehavior TargetDice
	{
		get
		{
			return this._targetDice;
		}
	}

	public int DiceFaceAdder
	{
		get
		{
			return this._statBonus.face;
		}
	}

	public int DamageAdder
	{
		get
		{
			return this._statBonus.dmg;
		}
	}

	public int BreakAdder
	{
		get
		{
			return this._statBonus.breakDmg;
		}
	}

	public int PowerAdder
	{
		get
		{
			return this._statBonus.power;
		}
	}

	public int GuardBreakAdder
	{
		get
		{
			return this._statBonus.guardBreakAdder;
		}
	}

	public int GuardBreakMultiplier
	{
		get
		{
			return this._statBonus.guardBreakMultiplier;
		}
	}

	public bool IsBlocked
	{
		get
		{
			return this._isBlocked;
		}
	}

	public int Index
	{
		get
		{
			return this._index;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckUsedBehaviourState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIndex(int index)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddAbility(DiceCardAbilityBase ability)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDiceFinalValue()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDiceVanillaMax()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDiceVanillaMin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDiceMin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDiceMax()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeforeRollDice(BattleDiceBehavior targetDice)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyAbilityAndStat(BattleDiceBehavior behavior)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollDice()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsParrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDamageRedution(int value)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBlocked(bool b)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDiceFace(int value)
	{

	}

	public DiceEffectType EffectType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiceEffect(DiceEffectType type)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyDice(DiceUITiming timing)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyDiceStatBonus(DiceStatBonus bonus)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddFlag(DiceFlag flag)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasFlag(DiceFlag flag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GiveDamage(BattleUnitModel target)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GiveDeflectDamage(BattleDiceBehavior targetDice)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndFarAreaBehaviourAtk(List<BattleUnitModel> damagedList, List<BattleUnitModel> defensedList)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveBeforeRollDiceStateForAchievements()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEventDiceAbility(DiceCardAbilityBase.DiceCardPassiveType dicePassiveType, BattleUnitModel target = null)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetScope()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsAttackDice(BehaviourDetail diceDetail)
	{
		throw null;
	}
}
