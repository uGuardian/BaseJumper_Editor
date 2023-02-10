using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_whiteNightEgo : DiceCardSelfAbilityBase
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
	public DiceCardSelfAbility_whiteNightEgo()
	{
		throw null;
	}

	public class BattleUnitBuf_whiteNight : BattleUnitBuf
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
		public override void OnRoundEndTheLast()
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
		private void SetToApostle(BattleUnitModel unit, int type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetToApostle1(BattleUnitModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetToApostle2(BattleUnitModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetToApostle3(BattleUnitModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetToApostle4(BattleUnitModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_whiteNight()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_apostle : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_apostle()
		{
			throw null;
		}
	}
}
