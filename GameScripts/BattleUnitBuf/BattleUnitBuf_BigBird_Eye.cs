﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_BigBird_Eye : BattleUnitBuf
{
	public BattleUnitModel fixedTarget;

	private bool _bActivated;

	protected override string keywordId
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
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<BattleUnitModel> GetFixedTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_BigBird_Eye()
	{
		throw null;
	}
}
