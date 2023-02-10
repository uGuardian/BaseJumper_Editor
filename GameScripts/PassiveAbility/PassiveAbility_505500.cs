using System;
using System.Runtime.CompilerServices;

public class PassiveAbility_505500 : PassiveAbilityBase
{
	protected const string _LIBRARIAN_HATRED = "Nihil_HatredLibrarian";

	protected const string _LIBRARIAN_DESPAIR = "Nihil_DespairLibrarian";

	protected const string _LIBRARIAN_GREED = "Nihil_GreedLibrarian";

	protected const string _LIBRARIAN_WRATH = "Nihil_WrathLibrarian";

	private PassiveAbility_505500.Phase _curPhase;

	private PassiveAbility_505500.Phase _nextPhase;

	private bool _bInit;

	private PassiveAbility_505503 _hatredPassive;

	private PassiveAbility_505504 _despairPassive;

	private PassiveAbility_505502 _greedPassive;

	private PassiveAbility_505505 _wrathPassive;

	private PassiveAbility_505501 _nihilPassive;

	public PassiveAbility_505500.Phase CurPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isInvincibleBp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNextPhase(PassiveAbility_505500.Phase p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanAddBuf(BattleUnitBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmuneDmg(DamageType type, KeywordBuf keyword = KeywordBuf.None)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsImmune(KeywordBuf buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreated()
	{
		throw null;
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
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveSpecificBufs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyStatToLibrarian(BattlePlayingCardDataInUnitModel targetCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsChanged(BattleUnitModel t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(PassiveAbility_505500.Phase p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_505500()
	{
		throw null;
	}

	public enum Phase
	{
		NIHIL,
		GREED,
		HATRED,
		DESPAIR,
		WRATH
	}
}
