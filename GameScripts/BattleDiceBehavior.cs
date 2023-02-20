using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleDiceBehavior
{
	public DiceBehaviour behaviourInCard;

	public List<DiceCardAbilityBase> abilityList;

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

	private DiceStatBonus _statBonus;

	private DiceStatBonus _firstStatBonus;

	public List<DiceFlag> _flags;

	private List<BattleUnitModel> _aliveOpponentList;

	private int _index;

	private DiceEffectType _effectType;

	public BattleUnitModel owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BehaviourType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BehaviourDetail Detail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int DiceResultValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int DiceVanillaValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool DiceDestroyed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int DiceResultDamage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleDiceBehavior TargetDice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int DiceFaceAdder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int DamageAdder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int BreakAdder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int PowerAdder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int GuardBreakAdder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int GuardBreakMultiplier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsBlocked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Index
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceBehavior()
	{
		throw null;
	}
}
