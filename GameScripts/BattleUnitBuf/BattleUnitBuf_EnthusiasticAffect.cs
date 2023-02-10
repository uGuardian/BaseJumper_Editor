using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_EnthusiasticAffect : BattleUnitBuf
{
	private bool _bCanAction;

	private bool _bActivated;

	private bool _bControlable;

	private bool _bRecoverBreak;

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected new virtual string keywordIconId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool IsControllable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsActionable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsInvincibleBp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsInvincibleHp(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBreakState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Destroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int currentSlot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_EnthusiasticAffect()
	{
		throw null;
	}
}
