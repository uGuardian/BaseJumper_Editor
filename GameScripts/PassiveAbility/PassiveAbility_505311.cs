using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_505311 : PassiveAbilityBase
{
	private const int _DIAMOND_UNIT_ID = 9050533;

	private const int _NORMAL_ATK_CARD_ID = 9905301;

	private const int _AREA_ATK_CARD_ID = 9905305;

	private const int _SPECIAL_DEF_CARD_ID = 9905322;

	private int _dmgReduction;

	private int _stack;

	private bool _bCanBreak;

	private bool _bCanBuf;

	private bool _bAddSpeeddiceOnce;

	private int _defaultPatternRoundCount;

	public override bool isInvincible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

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
	public void SetAreaAtkResult(bool breaked, bool buf)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
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
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetDamageReductionAll()
	{
		throw null;
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
	private void SetMapSpecialPortal()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_505311()
	{
		throw null;
	}
}
