using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UI;
using UnityEngine;

public class DiceAttackEffect_Binah_Pillar_Up : DiceAttackEffect
{
	[SerializeField]
	private List<AudioClip> _soundList;

	[SerializeField]
	private List<ParticleSystem> _makingPillarParticles;

	[SerializeField]
	private List<ParticleSystem> _particles;

	[SerializeField]
	private AnimationCurve _movingCurve;

	public const float MOVE_SPEED = 500f;

	public const float THROW_TIME = 1f;

	[SerializeField]
	private AudioClip _crashSound;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	private float _moveElapsed;

	private bool _bPillarCreated;

	private BattleUnitModel _targetModel;

	private bool _bFirstAnimEnd;

	private bool _bDestroyStart;

	private float _elapsedTimeForDestroy;

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
}
