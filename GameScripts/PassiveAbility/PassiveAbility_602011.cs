using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_602011 : PassiveAbilityBase
{
	private PassiveAbility_602011.Phase _curPhase;

	private int _eatCardRound;

	private BattleUnitModel _unitEaten;

	private int _bonusBp;

	public override bool isInvincible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleUnitModel unitEaten
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EatUnit(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMaxBpBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDestroyed()
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
	private void Polymorph()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpitUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetWillEatFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEatenFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_602011()
	{
		throw null;
	}

	public enum Phase
	{
		Normal,
		Eaten
	}

	public class BattleUnitBuf_BigBadWolf_Eaten : BattleUnitBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_BigBadWolf_Eaten()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(BattleUnitModel owner)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsTargetable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsActionable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			throw null;
		}
	}
}
