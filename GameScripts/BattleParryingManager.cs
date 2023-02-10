using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleParryingManager : Singleton<BattleParryingManager>
{
	private const int drawDiff = 1;

	private BattleParryingManager.ParryingTeam _teamEnemy;

	private BattleParryingManager.ParryingTeam _teamLibrarian;

	private BattleParryingManager.ParryingDecisionResult _decisionResult;

	private BattleParryingManager.ParryingTeam _currentWinnerTeam;

	private BattleParryingManager.ParryingTeam _currentLoserTeam;

	private BattleParryingManager.ParryingTeam _currentAttackerTeam;

	private BattleParryingManager.ParryingTeam _currentDefenderTeam;

	private BattleCardTotalResult _enemyCardBehavioursResult;

	private BattleCardTotalResult _librarianCardBehavioursResult;

	private bool cannAddForAction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetCurrentWinner()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartParrying(BattlePlayingCardDataInUnitModel cardEnemy, BattlePlayingCardDataInUnitModel cardLibrarian)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FirstApproachPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Decision()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSAtk()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSAtkDraw()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSDfn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSDfnDraw()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseDfnVSDfn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseDfnVSDfnDraw()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleParryingManager.ParryingDecisionResult GetDecisionResult(BattleParryingManager.ParryingTeam teamA, BattleParryingManager.ParryingTeam teamB)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckParryingEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndParrying()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckStandyDiceBeforeEndParrying(BattleParryingManager.ParryingTeam team)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RollDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndAction()
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
	private void SetBehaviourResultData(BattleParryingManager.ParryingTeam team, BattleParryingManager.ParryingTeam opponentTeam, BattleCardTotalResult result)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDiceResultData(BattleDiceBehavior diceBehavior, BattleCardTotalResult result, BattleDiceBehavior diceBehaviorforUI = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleParryingManager()
	{
		throw null;
	}

	public enum ParryingDiceType
	{
		Attack,
		Defense
	}

	public class ParryingTeam
	{
		public BattleUnitModel unit;

		public BattlePlayingCardDataInUnitModel playingCard;

		public bool isKeepedCard;

		private BattleParryingManager.ParryingTeam opponent;

		private static bool b;

		public int diceValue;

		public int resultKnockbackEnergy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(BattleUnitModel unit, BattlePlayingCardDataInUnitModel playingCard)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOpponent(BattleParryingManager.ParryingTeam opponent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NextDice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DiceExists()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetEmotionMultiplier()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleParryingManager.ParryingDiceType GetParryingDiceType()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardRange GetRange()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BehaviourType GetBehaviourType()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BehaviourDetail GetBehaviourDetail()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MotionDetail GetMotionDetail()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MotionDetail GetMotionDetailDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetDiceValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BeforeRollDice(BattleDiceBehavior targetDice)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RollDice()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateDiceFinalValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParryingTeam()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ParryingTeam()
		{
			throw null;
		}
	}

	public enum ParryingDecisionResult
	{
		WinEnemy,
		WinLibrarian,
		Draw
	}

	public enum ParryingAdvantage
	{
		None,
		AdvA,
		AdvB
	}
}
