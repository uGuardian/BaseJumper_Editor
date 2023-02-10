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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveSpecificBufs()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartTargetedOneSide(BattlePlayingCardDataInUnitModel attackerCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStartParrying(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyStatToLibrarian(BattlePlayingCardDataInUnitModel targetCard)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsChanged(BattleUnitModel t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckPhase()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNewPhase(PassiveAbility_505500.Phase p)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
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
