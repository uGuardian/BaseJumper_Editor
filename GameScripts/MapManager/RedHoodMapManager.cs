using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RedHoodMapManager : CreatureMapManager
{
	[Header("Reference")]
	[SerializeField]
	private List<SpriteRenderer> _berserkSprites;

	[SerializeField]
	private AnimationCurve _bgColorCurve;

	[SerializeField]
	private SpriteRenderer _berserkFilterSpr;

	[SerializeField]
	private int _berserkFilterFlag;

	[SerializeField]
	private SpriteRenderer _rageFilterSpr;

	[SerializeField]
	private Animator _rageFilterAnimator;

	[SerializeField]
	private FarAreaEffect _throwKnivesEffect;

	[SerializeField]
	private FarAreaEffect _nansaEffect;

	[SerializeField]
	private FarAreaEffect _howlingEffect;

	[Header("Runtime")]
	[SerializeField]
	private float _berserkRatio;

	private PassiveAbility_601011 _mercenaryPassive;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect GetThrowKnivesEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect GetNansaEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect GetHowlingEffect()
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
	public void SetMercenary(PassiveAbility_601011 p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBerserkGauge(int gauge)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ChangeBgColorRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNansaFilterObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHowlFilterObject(BattleUnitModel actor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetThrowKnivesObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBerserkFilter(int flag)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRageFilter()
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
	public RedHoodMapManager()
	{
		throw null;
	}
}
