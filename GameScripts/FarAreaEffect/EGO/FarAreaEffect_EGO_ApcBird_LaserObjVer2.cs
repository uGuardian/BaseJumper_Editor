using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_ApcBird_LaserObjVer2 : MonoBehaviour
{
	[SerializeField]
	private GameObject _root;

	[SerializeField]
	private GameObject _startObj;

	[SerializeField]
	private GameObject _shootObj;

	[SerializeField]
	private ParticleSystemRenderer _shootObjRenderer;

	[SerializeField]
	private List<GameObject> _shootChildObjList;

	[SerializeField]
	private TrailRenderer _shootObjTrail;

	[SerializeField]
	private float _shootTrailTime;

	[SerializeField]
	private GameObject _endObj;

	[SerializeField]
	private float _scaleFactor;

	[SerializeField]
	private float _speed;

	private ApocalypseBirdLaserCurveController _laserCtrl;

	private float _elapsedInit;

	private float _elapsedShoot;

	private bool _bArrived;

	private float _elapsedInitDelay;

	private float _delayInit;

	private bool _bInit;

	private bool _bPlaySound;

	public bool IsArrived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitDelay(ApocalypseBirdLaserCurveController laserCtrl, bool playSound)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(ApocalypseBirdLaserCurveController laserCtrl, bool playSound)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shoot()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableShootObj()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateBulletTransform(float ratio)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateStartObjRotation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_ApcBird_LaserObjVer2()
	{
		throw null;
	}
}
