using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_901021 : PassiveAbilityBase
{
	public const float hpRateDamage = 0.4f;

	public bool activated;

	private int _creatureCoreId;

	private Dictionary<BattleUnitModel, int> _combatCount;

	private List<PassiveAbility_901021.WeakBufInfo> _nextTurnWeakList;

	public override bool isTargetable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isActionable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndParrying(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndOneSideVictim(BattlePlayingCardDataInUnitModel attackerCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckCombat(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool OnCombatOtherChild(BattleUnitModel targetLibrarian)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetCombatCount(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddCombatCount(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetTakenGuardBreakDamageAdder(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_901021()
	{
		throw null;
	}

	private class WeakBufInfo
	{
		public BattleUnitModel unit;

		public int weakStack;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakBufInfo()
		{
			throw null;
		}
	}
}
