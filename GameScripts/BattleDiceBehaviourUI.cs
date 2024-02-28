using System;
using LOR_DiceSystem;

public class BattleDiceBehaviourUI
{
	public DiceBehaviour behaviourInCard;

	public BattleDiceCardModel cardmodel;

	public bool isDestroyed;

	public DiceUITiming destroyedTiming;

	public bool isSkip;

	public DiceUITiming skipTiming;

	private int _index = -1;

	public bool isRemoveInList;

	public bool isWinAgainstFarAtk;

	public DiceUITiming addedTimingWinAgainstFarAtk;

	public int Index
	{
		get
		{
			return this._index;
		}
	}

	public BattleDiceBehaviourUI(BattleDiceBehavior be)
	{
		this.behaviourInCard = be.behaviourInCard;
		this._index = be.Index;
		this.cardmodel = be.card.card;
		this.isDestroyed = be.DiceDestroyed;
		this.destroyedTiming = be.destroyedTiming;
		this.isWinAgainstFarAtk = be.winAgainstFarAtk;
		this.addedTimingWinAgainstFarAtk = DiceUITiming.AttackAfter;
	}

	public BattleDiceBehaviourUI(BattleDiceBehaviourUI be)
	{
		this.behaviourInCard = be.behaviourInCard;
		this._index = be.Index;
		this.cardmodel = be.cardmodel;
	}

	public void Copy(BattleDiceBehaviourUI b)
	{
		this.behaviourInCard = b.behaviourInCard;
		this.isDestroyed = b.isDestroyed;
		this.isSkip = b.isSkip;
		this._index = b.Index;
	}
}
