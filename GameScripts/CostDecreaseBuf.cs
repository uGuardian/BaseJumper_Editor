using System;
using System.Runtime.CompilerServices;

public class CostDecreaseBuf : BattleDiceCardBuf
{
	private bool isDestroy;

	public override DiceCardBufType bufType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetCost(int oldCost)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattleUnitModel owner)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CostDecreaseBuf()
	{
		throw null;
	}
}
