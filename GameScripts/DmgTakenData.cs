using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public struct DmgTakenData
{
	public BehaviourDetail damagedType;

	public AtkResist atkResist;

	public readonly int maxValue;

	public readonly int dmg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DmgTakenData(BehaviourDetail t, int dmg, int maxValue, AtkResist atkResist)
	{
		throw null;
	}
}
