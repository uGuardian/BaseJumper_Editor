using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_redHoodEgo : DiceCardSelfAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool OnChooseCard(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_redHoodEgo()
	{
		throw null;
	}

	public class BattleUnitBuf_redHood : BattleUnitBuf
	{
		private bool _init;

		private bool _mapRemoved;

		private string _mapName;

		public override KeywordBuf bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool isAssimilation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndSynchronize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemoveMap()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDie()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_redHood()
		{
			throw null;
		}
	}
}
