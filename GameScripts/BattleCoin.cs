﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleCoin
{
	public RWBPType rwbp;

	public RWBPType rwbpDefault;

	public int level;

	public List<BattleSlot> bufSlotList;

	public float damageBonus;

	public float messinessDamageBonus;

	public float predelayBonus;

	public float postdelayBonus;

	public RWBPType cardRwbp;

	public bool enhanced;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleCoin(RWBPType rwbp, RWBPType cardRwbpType, int lv = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPcoinAbility(RWBPType targetCoinType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncreaseLevel(int add)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecreaseLevel(int sub)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncreaseDamageBonus(float v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncreaseMessinessDamageBonus(float v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddSlotBuf(BattleSlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Enhance()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Change(RWBPType rwbp)
	{
		throw null;
	}
}
