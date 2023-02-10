using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class KingOfGreedMapManager : CreatureMapManager
{
	private const string _PORTAL_PREFAB_PATH = "Battle/CreatureEffect/5/KingOfGreed_Portal";

	public KingOfGreedMapManager.SpecialAtkInfo specialAtkKing;

	public List<KingOfGreedMapManager.SpecialAtkInfo> specialAtkTargets;

	public List<KingOfGreedMapManager.SpecialAtkInfo> specialAtkTargetWithNoReason;

	[SerializeField]
	private SpriteRenderer _filterReasonSpecialAtk;

	[SerializeField]
	private SpriteRenderer _filterNoReasonSpecialAtk;

	[SerializeField]
	private SpriteRenderer _breakFilter;

	[SerializeField]
	private SpriteRenderer _losingReasonFilter;

	[SerializeField]
	private Animator _animator;

	private int _elapsedRoundAfterPortalCreated;

	private bool _bPortalCreated;

	private int _elapsedRoundAfterPortalCreatedNoReason;

	private bool _bPortalCreatedNoReason;

	private bool _bCreateDialog;

	private bool _bReasonState;

	private int _bStateStack;

	private bool _bSuccessSpecialAtk;

	private SoundEffectPlayer _loopSoundNoReason;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialogState(bool reason, int stack, bool successSpecialAtk, bool breaked)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChangeFilter(EnemyTeamStageManager_KingOfGreed.Phase phase)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLosingReasonFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAreaAtkPortal(BattleUnitModel king)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAtkPortalNoReason(BattleUnitModel king, bool setTarget)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFilterAnimEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimPlaySound(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyPortals()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingOfGreedMapManager()
	{
		throw null;
	}

	public class SpecialAtkInfo
	{
		public GameObject portalEffect;

		public BattleUnitModel unit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpecialAtkInfo()
		{
			throw null;
		}
	}
}
