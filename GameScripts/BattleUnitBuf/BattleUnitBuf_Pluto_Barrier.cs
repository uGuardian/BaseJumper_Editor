using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleUnitBuf_Pluto_Barrier : BattleUnitBuf
{
	private const int _MAX_BREAK_RATE = -50;

	public BattleUnitModel linkedOpponent;

	private bool _bActivated;

	private GameObject _auraEffect;

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool IsControllable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel owner)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override StatBonus GetStatBonus()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsActionable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBreakState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDeadEvent(BattleUnitView view)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Destroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RecoverBreak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Pluto_Barrier()
	{
		throw null;
	}
}
