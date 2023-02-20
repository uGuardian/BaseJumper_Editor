using System;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Wizard_Scarecrow : BattleUnitBuf_Wizard_Role
{
	private bool _bEnterPhase;

	private const int _WISDOM_CARD_ID = 9907621;

	private const int _RETURN_LUMBERJACK_CARD_ID = 9907622;

	private const int _RETURN_LION_CARD_ID = 9907623;

	private const int _RETURN_WAYBACKHOME_CARD_ID = 9907624;

	private const int _RETURN_OZMA_CARD_ID = 9907625;

	protected override string keywordId
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
	public override void Init(BattleUnitModel owner)
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
	private bool IsScareCrowPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Wizard_Scarecrow()
	{
		throw null;
	}
}
