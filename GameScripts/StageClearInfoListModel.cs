using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class StageClearInfoListModel : Savable
{
	public const string save_stageInfoList = "stageInfoList";

	public const string save_stageUnlockedList = "stageUnlockedList";

	public const string save_stageId = "stageId";

	public const string save_clearCount = "clearCount";

	private Dictionary<LorId, StageClearInfoListModel.StageInfo> _stageInfoList;

	private HashSet<LorId> _stageUnlocked;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddClearCount(int stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddClearCount(LorId stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetClearCount(int stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetClearCount(LorId stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetClearCount(int stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetClearCount(LorId stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetClearCountForEndContents(int stageid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetClearCountForEndContents(LorId stageid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnlockStage(LorId stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUnlockedStage(LorId stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllUnloadedModClearInfos()
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageClearInfoListModel()
	{
		throw null;
	}

	public class StageInfo
	{
		public LorId stageId;

		public int clearCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageInfo()
		{
			throw null;
		}
	}
}
