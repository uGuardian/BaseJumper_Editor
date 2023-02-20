using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_505321 : PassiveAbilityBase
{
	private const int _SPECIAL_ATK_CARD_ID = 9905315;

	private const int _NORMAL_ATK_CARD_ID = 9905311;

	private const int _SPECIAL_DEF_CARD_ID = 9905323;

	private const int _DIAMOND_UNIT_ID = 9050533;

	private int _stack;

	private bool _bCanBreak;

	private bool _bRecover;

	private bool _bAddSpeeddiceOnce;

	private int _speedAddedCount;

	private bool _specialAtkFailTwice;

	private bool _specialAtkSuccess;

	private int _defaultPatternRoundCount;

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
	public void SetSpecialAtkResult(bool breaked, bool recover)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeGiveDamage(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int ChangeTargetSlot(BattleDiceCardModel card, BattleUnitModel target, int currentSlot, int targetSlot, bool teamkill)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UnregisterDiamonds()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckSpecialPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapDialogState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapSpecialPortal(bool targeting)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_505321()
	{
		throw null;
	}
}
