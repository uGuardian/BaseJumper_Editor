using System;
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

	public BattleCoin(RWBPType rwbp, RWBPType cardRwbpType, int lv = 1)
	{
		this.rwbp = rwbp;
		this.enhanced = false;
		this.bufSlotList = new List<BattleSlot>();
		this.rwbpDefault = rwbp;
		this.level = lv;
		this.cardRwbp = cardRwbpType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPcoinAbility(RWBPType targetCoinType)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncreaseLevel(int add)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecreaseLevel(int sub)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncreaseDamageBonus(float v)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IncreaseMessinessDamageBonus(float v)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddSlotBuf(BattleSlot slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Enhance()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Change(RWBPType rwbp)
	{

	}
}
