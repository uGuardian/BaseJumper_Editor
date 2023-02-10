using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DiceCardAbility_scarecrow_dmg_by_drain : DiceCardAbilityBase
{
	private const int _str = 1;

	private const int _endu = 1;

	private const int _recoverHpMin = 5;

	private const int _recoverHpMax = 10;

	private const int _dmgMin = 5;

	private const int _dmgMax = 20;

	private ScarecrowMapManager map;

	private Queue<bool> triggers;

	public override string[] Keywords
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private static int RecoverHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private static int Dmg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDrawParrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnLoseParrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckDrain(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Drain(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Effect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_scarecrow_dmg_by_drain()
	{
		throw null;
	}

	public class BattleUnitBuf_scarecrow_drain_success : BattleUnitBuf
	{
		private LorId _drained;

		private BattleDiceCardModel card;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_scarecrow_drain_success(LorId id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			throw null;
		}
	}
}
