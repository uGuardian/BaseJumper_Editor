using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleUnitBuf_Roland_4th_DmgReduction : BattleUnitBuf
{
	private const float _dmgPrevProb = 0.2f;

	private const int _dmgRedMin = 2;

	private const int _dmgRedMax = 5;

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private int DmgRed
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
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual BehaviourDetail GetDetailType()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetDamageReduction(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnBreakState()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Roland_4th_DmgReduction()
	{
		throw null;
	}
}
