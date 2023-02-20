using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;
using UI;

public class LibraryFloorModel : Savable
{
	public const string save_level = "level";

	public const string save_formationIndex = "formationIndex";

	public const string save_formationId = "formationId";

	public const string save_quest = "quest";

	public const string save_progress = "progress";

	public const string save_unitList = "unitList";

	private FormationModel _defaultFormation;

	private SephirahType _sephirah;

	private int _level;

	private int _temporaryLevel;

	private List<int> _formationIndex;

	private FormationModel _formation;

	private QuestModel _currentQuest;

	private List<UnitDataModel> _unitDataList;

	private int _opendUnitCount;

	private List<List<UIAbilitySlotTextData>> _abilitySlotTextID;

	private int _progress;

	public int Maxlevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public SephirahType Sephirah
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Level
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int TemporaryLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Exp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public FormationModel appliedFormation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Progress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTemporaryLevel(int level)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateOpenedCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateOpenedCount(int level)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UIAbilitySlotTextData> GetAbilitySlotTextList(int lv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAbilitySlotTextID()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnOpen()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetQuest(QuestXmlInfo quest)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOpenedUnitCount(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetOpendUnitCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnitData(int index, UnitDataModel data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitDataModel AddNewUnit(bool isSephirahChar, int indexId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitDataModel> GetUnitDataList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitDataModel GetUnitByPosition(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFormation(FormationModel formation)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetFormationIndex(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationPosition GetFormationPosition(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFormationPosition(UnitDataModel unit, FormationPosition targetPosition)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxExp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxExp(int lv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckLevelForAchievement()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LevelUp()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LevelDown()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckLevelUpQuest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckLevelUpExp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestModel GetQuestInfoInProgress()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEquipedCardCount(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<UnitDataModel> GetEquipedUnitList_partial(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CardOwnResult> GetEquipedUnitList(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExsistsUnique(DropBookXmlInfo dropBook)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookDropResult> FeedBook(DropBookXmlInfo book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetClearTheBlueProgress()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetClearTheBlueProgress()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsClearTheBluePrimaryProgress()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TemporayFormationSetting()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLevel(int level)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LibraryFloorModel()
	{
		throw null;
	}
}
