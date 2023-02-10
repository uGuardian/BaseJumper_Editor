using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TheClawStruggleAtk : MonoBehaviour
{
	private BattleUnitView _selfView;

	private BattleUnitView _targetView;

	[SerializeField]
	private AnimationCurve _chargeMovingCurve;

	[SerializeField]
	private float _chargeSpeed;

	[SerializeField]
	private AudioClip _upAtkSound;

	[SerializeField]
	private AnimationCurve _backMovingCurve;

	[SerializeField]
	private float _backSpeed;

	[SerializeField]
	private AudioClip _downAtkSound;

	[SerializeField]
	private AudioClip _chargeStartSound;

	[SerializeField]
	private AudioClip _comebackSound;

	private float _elapsedCharge;

	private float _elapsedBack;

	private Vector3 _srcPos;

	private Vector3 _dstPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitView self, BattleUnitView target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual_Charge(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateManual_ComeBack(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TheClawStruggleAtk()
	{
		throw null;
	}
}
