using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class PlatformCore
{
	protected HashSet<AchievementEnum> _unlockedAchievements;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashSet<AchievementEnum> GetUnlockedAchievements()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void AddAchievementCache(AchievementEnum achievement)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTheLastAchievement()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetOptionFilePath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnApplicationQuit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize(Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReInitialize(Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SavePlayData(int slot, SaveData data, Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadPlayData(int slot, Action<SaveData> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Save(string name, SaveData data, Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Load(string name, Action<SaveData> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AchievementUnlocked(AchievementEnum achievement)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UnlockAchievement(AchievementEnum achievement)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetLocale()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetWorkshopDirPath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlatformCore()
	{
		throw null;
	}
}
