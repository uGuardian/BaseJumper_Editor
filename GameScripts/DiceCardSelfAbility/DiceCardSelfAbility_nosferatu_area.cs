using System;
using System.Runtime.CompilerServices;

public class DiceCardSelfAbility_nosferatu_area : DiceCardSelfAbilityBase
{
	private const int _blood = -5;

	private const int _heal = 7;

	private const int _healRate = 1;

	private bool _bRecoveredFirst;

	public override string[] Keywords
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAreaAttack(BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardSelfAbility_nosferatu_area()
	{
		throw null;
	}
}
