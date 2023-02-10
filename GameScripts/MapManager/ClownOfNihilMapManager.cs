using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ClownOfNihilMapManager : CreatureMapManager
{
	[SerializeField]
	private Sprite _heartSpriteRes;

	[SerializeField]
	private Sprite _diamondSpriteRes;

	[SerializeField]
	private Sprite _cloverSpriteRes;

	[SerializeField]
	private Sprite _spadeSpriteRes;

	[SerializeField]
	private SpriteRenderer _phaseSpr;

	[SerializeField]
	private SpriteRenderer _bg;

	[SerializeField]
	private Animator _changePhaseAnimator;

	[SerializeField]
	private AudioClip _filterSound;

	[Header("분노의 시종 연출용")]
	[SerializeField]
	private ParticleSystem _ps;

	[SerializeField]
	private SpriteRenderer _acidParticleRoot;

	private List<GameObject> _acidParticleObjects;

	private const float _particleFadeOutTimeMin = 0.8f;

	private const float _particleFadeoutTimeMax = 1f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateAcidParticle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyParticles()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutParticles()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFilter(PassiveAbility_505500.Phase p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFilterAnimEvent(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClownOfNihilMapManager()
	{
		throw null;
	}
}
