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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyTempInstance()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_ApcBird_PutDownAtk()
	{
		throw null;
	}
}
