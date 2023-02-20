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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMercenary(PassiveAbility_601011 p)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBerserkGauge(int gauge)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ChangeBgColorRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNansaFilterObject()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHowlFilterObject(BattleUnitModel actor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetThrowKnivesObject()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBerserkFilter(int flag)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRageFilter()
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
	public RedHoodMapManager()
	{
		throw null;
	}
}
