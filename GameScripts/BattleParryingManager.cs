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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FirstApproachPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Decision()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSAtk()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSAtkDraw()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSDfn()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseAtkVSDfnDraw()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseDfnVSDfn()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhaseDfnVSDfnDraw()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private BattleParryingManager.ParryingDecisionResult GetDecisionResult(BattleParryingManager.ParryingTeam teamA, BattleParryingManager.ParryingTeam teamB)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckParryingEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndParrying()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckStandyDiceBeforeEndParrying(BattleParryingManager.ParryingTeam team)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RollDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndAction()
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
	private void SetBehaviourResultData(BattleParryingManager.ParryingTeam team, BattleParryingManager.ParryingTeam opponentTeam, BattleCardTotalResult result)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDiceResultData(BattleDiceBehavior diceBehavior, BattleCardTotalResult result, BattleDiceBehavior diceBehaviorforUI = null)
	{
		
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOpponent(BattleParryingManager.ParryingTeam opponent)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NextDice()
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RollDice()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateDiceFinalValue()
		{
			
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
