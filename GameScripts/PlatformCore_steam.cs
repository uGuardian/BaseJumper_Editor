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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplicationQuit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(Action<bool> callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SavePlayData(int slot, SaveData savedata, Action<bool> callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void LoadPlayData(int slot, Action<SaveData> callback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadWorkshopInvitationData(int slot)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UserInit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UnlockAchievement(AchievementEnum achivement)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool UnlockAchievementImpl(string achieveStr)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogError(object message)
	{
		
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
