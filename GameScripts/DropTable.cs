using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DropTable
{
	private List<LorId> _ids;

	private List<float> _probs;

	public List<LorId> Ids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<float> Probs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(float prob, LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<LorId> DropRemake(int emotionLevel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DropBookDataForAddedReward> DropRemakeCompare(int emotionLevel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CalculateDropProb(float originProb, int emotionLevel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DropTable()
	{
		throw null;
	}
}
