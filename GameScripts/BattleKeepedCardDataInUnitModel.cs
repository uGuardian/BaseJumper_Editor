using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleKeepedCardDataInUnitModel : BattlePlayingCardDataInUnitModel
{
	public BattleKeepedCardDataInUnitModel(BattleUnitModel unit)
	{
		this.isKeepedCard = true;
		this.owner = unit;
		this.target = null;
		this.card = null;
		this.cardAbility = null;
		this.earlyTarget = null;
		this.earlyTargetOrder = -1;
		this.slotOrder = -1;
		this.targetSlotOrder = -1;
		this.cardBehaviorQueue = new Queue<BattleDiceBehavior>();
		this.currentBehavior = null;
		this.currentBehaviorUI = null;
		this.speedDiceResultValue = -1;
		this.isFirstAction = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBehaviours(DiceCardXmlInfo cardInfo, List<BattleDiceBehavior> behaviourList)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBehaviours(BattleDiceCardModel card, List<BattleDiceBehavior> behaviourList)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBehaviour(BattleDiceCardModel card, BattleDiceBehavior behaviour)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBehaviourForOnlyDefense(BattleDiceCardModel card, BattleDiceBehavior behaviour)
	{

	}
}
