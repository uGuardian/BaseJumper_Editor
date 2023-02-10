using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Galaxy_CryAtk : FarAreaEffect
{
	[SerializeField]
	private Vector3 _dst;

	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private List<Transform> particles;

	[SerializeField]
	private AudioClip _sound;

	[SerializeField]
	private float _waitTime;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private float _runningTime;

	private float _elapsedWait;

	private float _elapsedRunning;

	private float _elapsedDestroy;

	private bool _bArrived;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_Galaxy_CryAtk()
	{
		throw null;
	}
}
