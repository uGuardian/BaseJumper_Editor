using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_805512 : PassiveAbilityBase
{
	private int _bufCycle;

	private bool _bCanBufBigEye;

	private bool _bCanBufLongArm;

	private bool _bCanBufSmallBeak;

	private float[] _hpRatioLimitAry;

	private int _hpRatioLimitIdx;

	private int _dmgReduction;

	private bool _bArrivedLimitHp;

	private bool _bAllBufDestroyed;

	private PassiveAbility_805513 _passive75;

	private PassiveAbility_805514 _passive50;

	private PassiveAbility_805515 _passive25;

	public bool CanBufBigEye
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool CanBufLongArm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool CanBufSmallBeak
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPatternPassive(PassiveAbility_805513 p75, PassiveAbility_805514 p50, PassiveAbility_805515 p25)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceBreakedAdder()
	{
		throw null;
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
	private void CheckBufState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExistBuf(List<BattleUnitModel> targets, Type bufType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExistBuf(BattleUnitModel target, Type bufType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveBigEyeBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveSmallBeakBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveLongArmBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapEggGlow(bool bigEyeOn, bool smallBeakOn, bool longArmOn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapEggBreak(bool bigEyeBreaked, bool smallBeakBreaked, bool longArmBreaked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetImageFilter(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyBigEyeBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroySmallBeakBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyLongArmBuf()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyNegativeBuf(List<BattleUnitBuf> bufList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeResist(PassiveAbility_805512.ResistPhase p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayPassiveDesc()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_805512()
	{
		throw null;
	}

	public enum ResistPhase
	{
		BigBird,
		PunishmentBird,
		JudgementBird,
		ApocalypseBird
	}
}
