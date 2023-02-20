using System;
using System.Runtime.CompilerServices;

public class BattleSlot
{
	private BattleCoin curCoin;

	private bool _isApplied;

	private BattleDiceCardModel _card;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleSlot()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleSlot(BattleDiceCardModel card)
	{
		throw null;
	}

	public bool IsApplied
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BattleDiceCardModel CurSlotCard
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCoin(BattleCoin coin)
	{
		
	}
}
