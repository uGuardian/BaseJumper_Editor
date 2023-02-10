using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StageWaveModel
{
	private List<UnitBattleDataModel> _unitList;

	private FormationModel _formation;

	private List<int> _formationIndex;

	private bool _defeated;

	public EmotionBattleTeamModel team;

	private SephirahType _defeatSephirah;

	private int _availableUnitNumber;

	private string _aggroScript;

	private string _managerScript;

	private StageWaveInfo _stageWaveInfo;

	private List<EmotionCardXmlInfo> _selectedList;

	public List<UnitBattleDataModel> UnitList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public SephirahType DefeatSephirah
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int AvailableUnitNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string AggroScript
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string ManagerScript
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(StageModel stage, StageWaveInfo waveInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFormationPosition(int i, Vector2Int v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationPosition GetFormationPosition(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationModel GetFormation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetFormationIndex(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Defeat()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefeatSephirah(SephirahType sep)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitBattleDataModel> GetUnitBattleDataList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetUnitBattleDataList(List<UnitBattleDataModel> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitBattleDataModel> GetUnitBattleDataListByFormation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyEmotionCard(EmotionCardXmlInfo card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUnavailable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSkillPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<EmotionCardXmlInfo> CreateSelectableList(int emotionLevel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PickRandomEmotionCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageWaveModel()
	{
		throw null;
	}
}
