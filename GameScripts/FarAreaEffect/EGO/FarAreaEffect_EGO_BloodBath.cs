using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_EGO_BloodBath : FarAreaEffect
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _waterSound;

	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private GameObject _bgEffect;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private FarAreaEffect_EGO_Heart_Hand _handEffectRes;

	[SerializeField]
	private float _waitHandTime;

	private List<FarAreaEffect_EGO_Heart_Hand> _handEffectList;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_BloodBath()
	{
		throw null;
	}
}
