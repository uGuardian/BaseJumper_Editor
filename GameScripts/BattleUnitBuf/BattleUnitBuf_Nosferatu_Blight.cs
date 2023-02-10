using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Nosferatu_Blight : BattleUnitBuf
{
	private const float _prob = 0.25f;

	private const float _hpLoseRate = 0.05f;

	private const float _hpCondition = 0.5f;

	private const int _str = 1;

	private const int _haste = 1;

	private const int _bleed = 5;

	private const int _stackDefault = 2;

	private bool _isControlable;

	private bool _added;

	private bool Prob
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

	public override bool IsControllable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int currentSlot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Nosferatu_Blight()
	{
		throw null;
	}
}
