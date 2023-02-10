using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimeScalableEffect : MonoBehaviour
{
	private float _timeScale;

	public Animator animator;

	public bool autoDestructOn;

	public float autoDestructTime;

	private float _elapsedTime;

	[NonSerialized]
	public BattleUnitModel parent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTimeScale(float scale)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdate(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFinished()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TimeScalableEffect()
	{
		throw null;
	}
}
