using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class LorId : IEquatable<LorId>, IEquatable<int>, IComparable<LorId>
{
	public readonly int id;

	public readonly string packageId;

	public static readonly LorId None;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LorId(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LorId(string packageId, int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBasic()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsWorkshop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(LorId other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(int other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(LorId lhs, int rhs)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(LorId lhs, int rhs)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(LorId lhs, LorId rhs)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(LorId lhs, LorId rhs)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LorId LoadFromSaveData(SaveData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(LorId other)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsModId(string packageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsBasicId(string packageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LorId MakeLorId(ILorIdXml src, string defaultPid)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeLorIds<T>(List<T> src, List<LorId> dst, string defaultPid) where T : ILorIdXml
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static LorId()
	{
		throw null;
	}
}
