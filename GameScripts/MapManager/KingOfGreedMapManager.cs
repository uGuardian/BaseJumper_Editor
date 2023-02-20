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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChangeFilter(EnemyTeamStageManager_KingOfGreed.Phase phase)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLosingReasonFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAreaAtkPortal(BattleUnitModel king)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpecialAtkPortalNoReason(BattleUnitModel king, bool setTarget)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFilterAnimEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimPlaySound(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyPortals()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
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
