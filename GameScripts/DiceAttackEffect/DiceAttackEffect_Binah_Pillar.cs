using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UI;
using UnityEngine;

public class DiceAttackEffect_Binah_Pillar : DiceAttackEffect
{
	[SerializeField]
	private List<AudioClip> _soundList;

	[SerializeField]
	private List<ParticleSystem> _makingPillarParticles;

	[SerializeField]
	private List<ParticleSystem> _particleTrails;

	[SerializeField]
	private AnimationCurve _movingCurve;

	[SerializeField]
	private float _moveSpeed;

	[SerializeField]
	private SpriteRenderer _linearDodge;

	[SerializeField]
	private AudioClip _crashSound;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	private float _moveElapsed;

	private bool _bPillarCreated;

	private BattleUnitModel _targetModel;

	private bool _bFirstAnimEnd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent_ThrowPillar()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent_EndFirstAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent_PlaySound(int i)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent_Destroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_Binah_Pillar()
	{
		throw null;
	}
}
