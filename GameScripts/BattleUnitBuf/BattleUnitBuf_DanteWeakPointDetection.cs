using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleUnitBuf_DanteWeakPointDetection : BattleUnitBuf
{
	private BehaviourDetail _hpWeakDetail;

	private BehaviourDetail _bpWeakDetail;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_DanteWeakPointDetection(BehaviourDetail hpWeakDetail, BehaviourDetail bpWeakDetail)
	{
		throw null;
	}

	public override BufPositiveType positiveType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override string bufActivatedText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEndBattlePhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetHpResistText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetBpResistText()
	{
		throw null;
	}
}
