using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_ApcBird_PutDownAtk : FarAreaEffect
{
	[SerializeField]
	private ApocalypseBirdObjectController _birdObject;

	[SerializeField]
	private GameObject _damageEffect;

	[SerializeField]
	private GameObject _characterDamagedEffect;

	[SerializeField]
	private Vector3 _damageEffectRefPos;

	[SerializeField]
	private float _destroyTime;

	private float _elapsedDestroy;

	private ApocalypseBirdObjectController _tempBirdObjInstance;

	private bool _bEffectEnd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyTempInstance()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_ApcBird_PutDownAtk()
	{
		throw null;
	}
}
