using System;
using System.Runtime.CompilerServices;

public class DiceCardAbility_nothingEgoDice : DiceCardAbilityBase
{
	private string _PREFAB_PATH;

	private BattleUnitModel _target;

	public override string[] Keywords
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceCardAbility_nothingEgoDice()
	{
		throw null;
	}
}
