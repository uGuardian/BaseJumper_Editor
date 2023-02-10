using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_CryingChild_EyeLaser : FarAreaEffect
{
	[SerializeField]
	private float _xMin;

	[SerializeField]
	private float _xMax;

	[SerializeField]
	private float _zMin;

	[SerializeField]
	private float _zMax;

	[SerializeField]
	private float _speed;

	[SerializeField]
	private AnimationCurve _lerpCurve;

	[SerializeField]
	private List<LaserController> _laserList;

	[SerializeField]
	private float _waitTime;

	[SerializeField]
	private List<Transform> _randomPoint;

	[SerializeField]
	private AudioClip _laserSound;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PickPosition(Transform t, LaserController l)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MoveToRandomPos(Vector3 p, Transform t, LaserController l)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_CryingChild_EyeLaser()
	{
		throw null;
	}
}
