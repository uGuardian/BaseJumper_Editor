using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class CustomSaveStorageModel
{
	public const string KETER_FINAL_ANGELA_SAVE_NAME = "KeterAngelaEgo";

	private Dictionary<string, SaveData> _storage;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStageStorgeData(string name, SaveData value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetStageStorageData(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData saveData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomSaveStorageModel()
	{
		throw null;
	}
}
