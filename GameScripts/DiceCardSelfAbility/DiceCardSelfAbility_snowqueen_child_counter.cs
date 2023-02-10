using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_snowqueen_child_counter : DiceCardSelfAbilityBase
{
	private const int _dmgMin = 5;

	private const int _dmgMax = 5;

	private const int _stackMax = 2;

	private static int Dmg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_snowqueen_child_counter()
	{
		throw null;
	}

	public class BattleUnitBuf_SnowQueen_Child_Counter : BattleUnitBuf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_SnowQueen_Child_Counter()
		{
			throw null;
		}
	}
}
