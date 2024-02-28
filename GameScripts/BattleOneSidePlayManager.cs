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

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetCurrentAttacker()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NextDice()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PreDecision()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Decision()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Action()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckEndAction()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndCardAction()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BeforeRollDice()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AfterRollDice()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAbilityDataBeforeRoll(BattleUnitModel model, BattleCardTotalResult result)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAbilityDataAfterRoll(BattleUnitModel model, BattleCardTotalResult result)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetBehaviourResultData(BattleDiceBehavior behaviour, BattleDiceBehavior opponentBehaviour, BattleCardTotalResult result, BattleDiceBehavior behaviorForDiceUI = null)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDiceResultData(BattleDiceBehavior diceBehavior, BattleCardTotalResult result, BattleDiceBehavior diceBehaviorforUI = null)
	{

	}

	private enum OneSidePlayPhase
	{
		PreDecision,
		Decision,
		Action,
		End
	}
}
