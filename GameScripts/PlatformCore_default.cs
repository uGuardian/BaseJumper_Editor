using System;
using System.Runtime.CompilerServices;
using GameSave;

public class PlatformCore_default : PlatformCore
{
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
	public override void Save(string name, SaveData data, Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Load(string name, Action<SaveData> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogError(object message)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlatformCore_default()
	{
		throw null;
	}
}
