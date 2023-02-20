using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_ApcBird_LaserVer2 : FarAreaEffect
{
	[SerializeField]
	private Vector3 _targetCenterPos;

	[SerializeField]
	private float _xRange;

	[SerializeField]
	private float _zRange;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private ApocalypseBirdObjectController _birdObject;

	[SerializeField]
	private FarAreaEffect_EGO_ApcBird_LaserObjVer2 _laserObject;

	private List<FarAreaEffect_EGO_ApcBird_LaserObjVer2> _laserList;

	private ApocalypseBirdObjectController _tempBirdObjInstance;

	private float _elapsedDestroy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Transform> InitBirdObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 InitCenterPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_ApcBird_LaserVer2()
	{
		throw null;
	}
}
