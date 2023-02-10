using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_EGO_Heart : FarAreaEffect
{
	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private SpriteRenderer _bg;

	[SerializeField]
	private GameObject _atkEffect;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private float _waitTimeAfterDmg;

	[SerializeField]
	private float _waitTimeAfterEnd;

	private float _elapsedAfterEffect;

	private float _elapsedEnd;

	private Vector3 _startPos;

	private FarAreaEffect_EGO_Heart.Phase _phase;

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
	private void OnDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_Heart()
	{
		throw null;
	}

	public enum Phase
	{
		StartMove,
		Effect,
		Wait,
		Return,
		End
	}
}
