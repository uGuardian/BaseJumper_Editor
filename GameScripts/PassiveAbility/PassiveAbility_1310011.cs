using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1310011 : PassiveAbilityBase
{
	private const int vibrateUp = 703001;

	private const int vibrateDown = 703002;

	private const int vibrateDownLose = 703003;

	private const int normalActtack = 703004;

	private const int strengthCard = 703005;

	private const int continuAtk = 703011;

	private const int blueCard = 703012;

	private const int resonance1 = 703031;

	private const int resonance2 = 703031;

	private const int phase1hp = 375;

	private const int phase2hp = 25;

	private int _patternCount;

	private int _phase;

	private int _nextPhase;

	private List<int> _currentSpeeds;

	private int _addedDiceCardCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetSpeedDiceAdder(int speedDiceResult)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetCurrentSpeedDiceNum()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetMinHp()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAfterRollSpeedDice()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards_phase1()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards_phase2()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards_phase3()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetOpponentVibeStack()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int TryToAddResonance()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int AddNewCard(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetAddedDiceCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetPriorityAdder(BattleDiceCardModel card, int speed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool BeforeTakeDamage(BattleUnitModel attacker, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1310011()
	{
		throw null;
	}

	public class BattleUnitBuf_battle : BattleUnitBuf
	{
		public int hpAdder;

		public int breakGageAdder;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_battle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatBonus GetStatBonus()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int SpeedDiceNumAdder()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStartAfter()
		{
			
		}
	}
}
