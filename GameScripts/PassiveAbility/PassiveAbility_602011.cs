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
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Polymorph()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SpitUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetWillEatFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetEatenFilter(bool b)
	{
		
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			
		}
	}
}
