using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OzmaMapManager : CreatureMapManager
{
	private PassiveAbility_704011.Phase _phase;

	private PassiveAbility_705411.Phase _phaseBoss;

	[SerializeField]
	private SpriteRenderer _normalFilterSpr;

	[SerializeField]
	private SpriteRenderer _oblivionFilterSpr;

	[SerializeField]
	private float _filterSpeed;

	[SerializeField]
	private AnimationCurve _filterCurve;

	[SerializeField]
	private SpriteRenderer _struggleFilter;

	[SerializeField]
	private SpriteRenderer _rageFilter;

	private float _elapsedBreakFilterEnabled;

	private Coroutine _filterRoutine;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMapDialogueState(PassiveAbility_704011.Phase p)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMapDialogueState(PassiveAbility_705411.Phase p)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStruggleFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRageFilter(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOblivionSuccessFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMeetingPumpkinFilter(bool hasOblivion)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MeetRoutine(SpriteRenderer r)
	{
		throw null;
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
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OzmaMapManager()
	{
		throw null;
	}
}
