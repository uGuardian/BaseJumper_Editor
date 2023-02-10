using System;
using System.Runtime.CompilerServices;
using GameSave;

public class LatestDataModel
{
	public int LatestStorychapter;

	public int LatestStorygroup;

	public int LatestStoryepisode;

	public int RuinTitle;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LatestDataModel Clone()
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
	public LatestDataModel()
	{
		throw null;
	}
}
