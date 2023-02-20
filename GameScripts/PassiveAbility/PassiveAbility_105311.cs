using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_105311 : PassiveAbilityBase
{
	private const int _RECOVER_AMOUNT_ALLY = 10;

	private const int _RECOVER_SELF_BY_ATK = 10;

	private const int _LIMIT_ACCMULATED_DMG = 40;

	private const int _RECOVER_AMOUNT_BY_KILL_ALLY = 40;

	private const int _STRENGTH_PER_UNIT = 2;

	private const int _RECOVER_AMOUNT_BY_LEASTHP = 20;

	private BattleUnitModel _target;

	private int _accumulatedDmgTaken;

	private int _strengthStack;

	private BattleUnitBuf_MalkuthFinal_FairyMeal _mealBuf;

	private bool _bActiveLethal;

	private List<BattleUnitModel> _fairyHenchmanList;

	private bool _recoverBreakOnRoundStart;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxHpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxBpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDestroyed()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateHenchmen()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSpec()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDeck()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_105311()
	{
		throw null;
	}
}
