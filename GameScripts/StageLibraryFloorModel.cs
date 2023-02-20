using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class StageLibraryFloorModel
{
	public const int blackSilenceBookId_finalVer = 180003;

	public const int redMistBookId_finalVer = 180004;

	public const int binahBookId_finalVer = 180005;

	public const int angelaBookId = 9100501;

	public LibraryFloorModel _floorModel;

	private List<UnitBattleDataModel> _unitList;

	private bool _defeated;

	public EmotionBattleTeamModel team;

	private List<EmotionCardXmlInfo> _selectedList;

	private List<EmotionEgoXmlInfo> _selectedEgoList;

	private List<EmotionCardXmlInfo> _selectableList;

	private List<EmotionEgoXmlInfo> _selectableEgoList;

	private List<UnitBattleDataModel> addedunitList;

	public SephirahType Sephirah
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(StageModel stage, LibraryFloorModel floor, bool isRebattle = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitUnitList(StageModel stage, LibraryFloorModel floor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitUnitList_finalStage(StageModel stage, LibraryFloorModel floor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitUnitList_KeterFinalFloor(StageModel stage, LibraryFloorModel floor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddUnitDefault(StageModel stage, LibraryFloorModel floor, UnitDataModel data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddRolandInOlivierStage(StageModel stage, LibraryFloorModel floor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddAngelaInsteadRoland(StageModel stage, LibraryFloorModel floor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitBattleDataModel> GetUnitBattleDataList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitBattleDataModel> GetUnitAddedBattleDataList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmotionTeamUnit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitBattleDataModel> GetUnitBattleDataListByFormation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationPosition GetFormationPosition(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationModel GetFormation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateEmotionCoin()
	{
		
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
	private List<EmotionCardXmlInfo> CreateRandomSelectableList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EmotionCardXmlInfo RandomSelect(List<EmotionCardXmlInfo> duplicated, MentalState state, int grade)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<EmotionEgoXmlInfo> CreateSelectableEgoList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EmotionEgoXmlInfo RandomSelectEgo(List<EmotionEgoXmlInfo> duplicated)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UseSkillPoint()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPickPassiveCard(EmotionCardXmlInfo card, BattleUnitModel target = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPickEgoCard(EmotionEgoXmlInfo egoCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartPickEmotionCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Defeat()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUnavailable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageLibraryFloorModel()
	{
		throw null;
	}
}
