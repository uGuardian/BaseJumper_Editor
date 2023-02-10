using System;
using System.Runtime.CompilerServices;

public class BattleOneSidePlayManager : Singleton<BattleOneSidePlayManager>
{
	public BattleUnitModel attacker;

	public BattleUnitModel victim;

	private BattlePlayingCardDataInUnitModel _playingCard;

	private int resultKnockbackEnergy;

	private BattleCardTotalResult _attackerCardBehavioursResult;

	private BattleCardTotalResult _victimCardBehavioursResult;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartOneSidePlay(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetCurrentAttacker()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NextDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PreDecision()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Decision()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Action()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckEndAction()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndCardAction()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BeforeRollDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AfterRollDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAbilityDataBeforeRoll(BattleUnitModel model, BattleCardTotalResult result)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAbilityDataAfterRoll(BattleUnitModel model, BattleCardTotalResult result)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBehaviourResultData(BattleDiceBehavior behaviour, BattleDiceBehavior opponentBehaviour, BattleCardTotalResult result, BattleDiceBehavior behaviorForDiceUI = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDiceResultData(BattleDiceBehavior diceBehavior, BattleCardTotalResult result, BattleDiceBehavior diceBehaviorforUI = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleOneSidePlayManager()
	{
		throw null;
	}

	private enum OneSidePlayPhase
	{
		PreDecision,
		Decision,
		Action,
		End
	}
}
