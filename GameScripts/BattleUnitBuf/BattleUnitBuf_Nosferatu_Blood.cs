﻿using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Nosferatu_Blood : BattleUnitBuf
{
	private const float _hpRate = 0.05f;

	private int _accumulatedHp;

	private int reserve;

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
	public override void OnLoseHp(int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseStack(int value = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reserve(int value = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Nosferatu_Blood()
	{
		throw null;
	}
}
