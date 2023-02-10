using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_BigBird_Darkness : FarAreaEffect
{
	[SerializeField]
	private AudioClip _sound;

	[SerializeField]
	private SpriteRenderer _bg;

	[SerializeField]
	private GameObject _particle;

	private float _elapsedParticle;

	private bool _bActiveBg;

	private bool _bEndEffect;

	private float _elapsedDestroy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnAnimEvent(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

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
	private void SetDarknessFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_BigBird_Darkness()
	{
		throw null;
	}
}
