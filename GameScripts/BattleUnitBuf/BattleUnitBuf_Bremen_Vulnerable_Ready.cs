﻿using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Bremen_Vulnerable_Ready : BattleUnitBuf
{
	public override bool Hide
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Bremen_Vulnerable_Ready()
	{
		throw null;
	}
}