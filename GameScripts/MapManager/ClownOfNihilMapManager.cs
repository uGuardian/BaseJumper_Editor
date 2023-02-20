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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyParticles()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutParticles()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFilter(PassiveAbility_505500.Phase p)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFilterAnimEvent(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeDlgByBoss()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClownOfNihilMapManager()
	{
		throw null;
	}
}
