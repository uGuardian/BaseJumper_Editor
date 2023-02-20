using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EmotionBattleTeamModel
{
	public Faction faction;

	public StageClassInfo stage;

	public SephirahType sep;

	private List<UnitBattleDataModel> _unitlist;

	private int _emotionLevel;

	private int _prevEmotionLevel;

	public int emotionLevelMax;

	private int _emotionTotalCoinNumber;

	public int emotionTotalBonus;

	private int _emotionCoinNumber;

	private int _currentLevelNeedEmotionMaxCoin;

	public int skillPoint;

	public int egoSelectionPoint;

	public int currentSelectEmotionLevel;

	private int _emotionCoinNumberForEgoCooltime;

	private int _currentLevelNeedEmotionMaxCointForEgo;

	public int emotionLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int prevEmotionLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int emotionTotalCoinNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	public int emotionTotalCoinNumberWithBonus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int emotionCoinNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int currentLevelNeedEmotionMaxCoin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int EmotionCoinNumberForEgoCooltime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int currentLevelNeedEmotionMaxCointForEgo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionBattleTeamModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<UnitBattleDataModel> units, Faction faction, StageClassInfo stage = null, SephirahType sep = SephirahType.None, int maxLevel = 5)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnitList(List<UnitBattleDataModel> units)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddUnit(UnitBattleDataModel unit)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitBattleDataModel> GetList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateUnitList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCoin()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitBattleDataModel> GetAliveSelectedUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateEgoCooltimeCoin()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxEgoCooltimeCoin()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetEgoCooltimeCoin()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckMaxLevel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanUsingEgo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTotalPositiveCoin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTotalNegativeCoin()
	{
		throw null;
	}
}
