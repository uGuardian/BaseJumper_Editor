using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_150051 : PassiveAbilityBase
{
	private const int powerDownCardId = 611024;

	private const int hpLine = 300;

	private const int handStunLine = 30;

	private int _patternCountPhase1;

	private int _patternCountPhase2;

	private int _patternCountPhase3;

	private bool _unionState;

	private int _currentPhase;

	private int _areaCool;

	private List<BattleUnitModel> _powerDownHands;

	private List<BattleUnitModel> _noPowerDownHands;

	public override bool isTargetable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDefenseCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCardsInHands()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsPowerCard(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsNullifyCard(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsRecoverCard(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Join()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Split()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CanJoin()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CanSplit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExistsHands()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExistsAliveHands()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExistsDeadHand()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetHandList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<PassiveAbility_150039> GetHandPassiveList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeSkin(string skinName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_150051()
	{
		throw null;
	}

	public class BattleUnitBuf_yanAreaReady : BattleUnitBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_yanAreaReady()
		{
			throw null;
		}
	}
}
