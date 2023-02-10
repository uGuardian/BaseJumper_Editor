using System;
using System.Runtime.CompilerServices;
using GameSave;

public class PlatformCore_steam : PlatformCore_default
{
	private const string path = "common\\Library Of Ruina";

	private const string adding = "workshop\\content\\{0}\\";

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplicationQuit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SavePlayData(int slot, SaveData savedata, Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void LoadPlayData(int slot, Action<SaveData> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadWorkshopInvitationData(int slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UserInit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UnlockAchievement(AchievementEnum achivement)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool UnlockAchievementImpl(string achieveStr)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogError(object message)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetWorkshopDirPath()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlatformCore_steam()
	{
		throw null;
	}
}
