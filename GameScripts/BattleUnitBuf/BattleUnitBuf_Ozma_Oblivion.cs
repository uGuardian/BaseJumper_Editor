using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleUnitBuf_Ozma_Oblivion : BattleUnitBuf
{
	private const int _NORMAL_PUMPKIN_ID = 9070402;

	private const int _FINAL_PUMPKIN_ID = 9070542;

	private bool _bActivated;

	private List<BattleUnitBuf_Ozma_Oblivion.ChangedDeckInfo> _deckInfo;

	protected override string keywordIconId
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsDeckCleared()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetAndDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel owner)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSuccessAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Destroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeDeck()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckDeck()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ReadyToOrigin(List<BattleDiceCardModel> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KillPumpkins()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_Ozma_Oblivion()
	{
		throw null;
	}

	public class ChangedDeckInfo
	{
		public LorId originalCardId;

		public LorId changedCardId;

		public BattleDiceCardModel changedCard;

		public bool bReturnedToOriginal;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangedDeckInfo()
		{
			throw null;
		}
	}
}
