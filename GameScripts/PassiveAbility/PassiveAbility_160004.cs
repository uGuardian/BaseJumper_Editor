using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_160004 : PassiveAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_160004()
	{
		throw null;
	}

	public class BattleUnitBuf_battle : BattleUnitBuf
	{
		public int hpAdder;

		public int breakGageAdder;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_battle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatBonus GetStatBonus()
		{
			throw null;
		}
	}
}
