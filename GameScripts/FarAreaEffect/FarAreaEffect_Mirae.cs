using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Mirae : FarAreaEffect
{
	[SerializeField]
	private GameObject _atkEffect;

	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _atkSound;

	[SerializeField]
	private float _startDelay;

	[SerializeField]
	private float _atkDelay;

	[SerializeField]
	private float _afterAtkDelay;

	[SerializeField]
	private float _endDelay;

	private float _elapsed;

	private Vector3 _originPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FocusCam(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Mirae()
	{
		throw null;
	}
}
