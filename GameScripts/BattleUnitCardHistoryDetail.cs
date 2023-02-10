using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleUnitCardHistoryDetail
{
	private BattleUnitModel _self;

	private List<BattleUnitCardHistoryDetail.History> _historyList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitCardHistoryDetail(BattleUnitModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCardHistory(BattlePlayingCardDataInUnitModel card, int round)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattlePlayingCardDataInUnitModel> GetCurrentRoundCardList(int round)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattlePlayingCardDataInUnitModel> GetPreviousRoundCardList(int round)
	{
		throw null;
	}

	public class History
	{
		public int round;

		public BattlePlayingCardDataInUnitModel card;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public History()
		{
			throw null;
		}
	}
}
