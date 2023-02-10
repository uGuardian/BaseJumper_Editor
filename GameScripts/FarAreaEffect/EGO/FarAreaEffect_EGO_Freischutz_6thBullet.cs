using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Freischutz_6thBullet : FarAreaEffect
{
	public AudioClip sound;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private float _waitTimeShotSound;

	[SerializeField]
	private GameObject _fireObject;

	[SerializeField]
	private SpriteRenderer _lineardodge;

	[SerializeField]
	private float _doneTime;

	[SerializeField]
	private List<Transform> _bullets;

	[SerializeField]
	private GameObject _bulletRoot;

	private bool _shotBullets;

	private float _elapsed;

	private float _elapsedSound;

	private float _elapsedDone;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_Freischutz_6thBullet()
	{
		throw null;
	}
}
