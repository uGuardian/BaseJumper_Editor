using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1005312 : PassiveAbilityBase
{
	public List<PassiveAbility_1005312.LieCardInfo> lieCardInfoList;

	public int failLyingCount;

	private const int _LYING_DETECTION_CARD_ID = 9910301;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLieCard(BattleDiceCardModel equippedCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartOneSidePlay(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttackEvent(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1005312()
	{
		throw null;
	}

	public class LieCardInfo
	{
		public BattleDiceCardModel lieCard;

		public BattleDiceCardModel equippedCard;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LieCardInfo()
		{
			throw null;
		}
	}
}
