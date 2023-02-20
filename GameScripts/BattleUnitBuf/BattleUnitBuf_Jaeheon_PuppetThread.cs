using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Jaeheon_PuppetThread : BattleUnitBuf
{
	private const int _PUPPET_NORMAL_ID = 1307021;

	private const int _PUPPET_QUICK_ID = 1307031;

	private const int _PUPPET_HEAVY_ID = 1307041;

	private const int _PUPPET_ANGELICA_ID = 1307051;

	private const int _SPECIAL_CARD_ID_NORMAL_PUPPET = 703720;

	private const int _SPECIAL_CARD_ID_QUICK_PUPPET = 703721;

	private const int _SPECIAL_CARD_ID_HEAVY_PUPPET = 703722;

	private const int _SPECIAL_CARD_ID_ANGELICA_PUPPET = 703723;

	private int _decreaseValue;

	public override KeywordBuf bufType
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

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int ReversedDecreaseValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecreaseStack(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDrawCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int currentSlot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetSpecialCardId()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Jaeheon_PuppetThread()
	{
		throw null;
	}
}
