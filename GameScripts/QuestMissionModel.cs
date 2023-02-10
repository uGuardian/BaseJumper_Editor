using System;
using System.Runtime.CompilerServices;
using GameSave;

public class QuestMissionModel : Savable
{
	public const string save_id = "id";

	public const string save_count = "count";

	public const string save_detail = "detail";

	private QuestModel _quest;

	private QuestMissionScriptBase _script;

	public QuestMissionXmlInfo _xmlInfo;

	private int _count;

	public QuestMissionScriptBase script
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDesc()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestMissionModel(QuestModel quest, QuestMissionXmlInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCount(int v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFinished()
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
}
