﻿using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Decay : BattleUnitBuf
{
	private bool _isYanDecay;

	private int reserve;

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override BufPositiveType positiveType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override KeywordBuf bufType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected override string keywordIconId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Decay()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reserve(int value = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(int value = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeToYanDecay()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintEffect()
	{
		
	}
}
