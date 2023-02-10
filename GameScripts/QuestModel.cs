using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class QuestModel : Savable
{
	public const string save_id = "id";

	public const string save_missionList = "missionList";

	private QuestXmlInfo _xmlInfo;

	private List<QuestMissionModel> _missionList;

	private SephirahType _sephirah;

	public QuestXmlInfo XmlInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<QuestMissionModel> missionList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string StoryName
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestModel(QuestXmlInfo info, SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFinished()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRemainQuestNumber()
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
		throw null;
	}

	public delegate bool MissionEvent();

	public delegate bool MissionEvent<in T>(T obj);
}
