using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Xiao_Taotie : FarAreaEffect
{
	[SerializeField]
	private AudioClip _soundStart;

	[SerializeField]
	private AudioClip _soundEnd;

	[SerializeField]
	private float _dragonScaleFactor;

	[SerializeField]
	private Transform _planeTransform;

	[SerializeField]
	private GameObject _collisionObj;

	[SerializeField]
	private FarAreaEffect_Xiao_Taotie_DragonAnimListener _dragonAnimListener;

	[SerializeField]
	private float _earthquakeTime;

	[SerializeField]
	private float _earthquakeSpeed;

	[SerializeField]
	private float _earthquakePower;

	[SerializeField]
	private GameObject _effectRoot;

	private bool _bMoved;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDragonPosition(Transform t)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateInit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerator FilterCoroutine(CameraFilterPack_FX_EarthQuake q)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Xiao_Taotie()
	{
		throw null;
	}
}
