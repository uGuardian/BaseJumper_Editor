using System;
using System.Runtime.CompilerServices;
using GameSave;

public class PlatformSave
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize(PlatformCore user, Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SaveAsync(string name, SaveData data, Action<bool> callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual SaveData LoadAsync(string name)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlatformSave()
	{
		throw null;
	}
}
