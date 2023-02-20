using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_TwistedElena2 : FarAreaEffect
{
	[Header("Absorb Effect")]
	[SerializeField]
	private GameObject _absorbEffectRes;

	[SerializeField]
	private float _absorbDelay;

	[SerializeField]
	private GameObject _doneEffect;

	[Header("Attack Effect")]
	[SerializeField]
	private GameObject _damagedEffectRes;

	[SerializeField]
	private GameObject _clawAtkEffect;

	[SerializeField]
	private GameObject _chargeEffect;

	[SerializeField]
	private UIAnimationEventHandler _chargeEffectAnimHandler;

	[SerializeField]
	private float _chargeDelay;

	[SerializeField]
	private AnimationCurve _chargeCurve;

	[SerializeField]
	private AudioClip _chargeSound;

	[Header("End")]
	[SerializeField]
	private float _endDelay;

	[Header("Teleport Effect")]
	[SerializeField]
	private GameObject _teleportEffectRes;

	private List<AbsorbEffectInfo> _absorbEffectList;

	private float _elapsedAbsorb;

	private float _elapsedCharge;

	private Vector3 _chargeStartPos;

	private Vector3 _chargeDstPos;

	private float _elapsedEnd;

	private Vector3 _returnPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void GiveDamageFromManager(List<BattleUnitModel> damagedUnitList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_TwistedElena2()
	{
		throw null;
	}
}
