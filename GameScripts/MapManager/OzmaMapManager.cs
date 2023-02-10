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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMapDialogueState(PassiveAbility_705411.Phase p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStruggleFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRageFilter(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOblivionSuccessFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMeetingPumpkinFilter(bool hasOblivion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MeetRoutine(SpriteRenderer r)
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
	public OzmaMapManager()
	{
		throw null;
	}
}
