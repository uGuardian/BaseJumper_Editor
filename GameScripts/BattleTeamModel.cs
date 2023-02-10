using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleTeamModel
{
	public int needScoreForStack;

	private List<BattleUnitModel> _list;

	private int[] _emotionScoreNums;

	public int[] emotionScoreNums
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddUnit(BattleUnitModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleUnitModel> GetListByGrade(UnitGradeType grade)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleTeamModel()
	{
		throw null;
	}
}
