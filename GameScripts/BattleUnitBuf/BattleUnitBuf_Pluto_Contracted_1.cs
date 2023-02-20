using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Pluto_Contracted_1 : BattleUnitBuf
{
	private const int _CONTRACT_CARD_ID = 703906;

	private List<int> _forbidCostList;

	private int _forbidCost;

	private bool _bUsedForbidCost;

	private bool _bActivated;

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override string bufActivatedText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public new string bufActivatedNameWithStack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel owner)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetForbidCost()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeCardCost()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Pluto_Contracted_1()
	{
		throw null;
	}

	public class RandomCostBuf : BattleDiceCardBuf
	{
		private int _cost;

		public override DiceCardBufType bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RandomCostBuf(int cost)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetCost(int oldCost)
		{
			throw null;
		}
	}
}
