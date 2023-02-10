using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TheClawChargeAtk : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _chargeMovingCurve;

	[SerializeField]
	private float _chargeSpeed;

	[SerializeField]
	private AudioClip _chargeSound;

	[SerializeField]
	private GameObject _trailEffect;

	private float _elapsedCharge;

	private BattleUnitView _selfView;

	private BattleUnitView _targetView;

	private Vector3 _src;

	private Vector3 _dst;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitView self, BattleUnitView target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TheClawChargeAtk()
	{
		throw null;
	}
}
