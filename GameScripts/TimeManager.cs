using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
	private static TimeManager _instance;

	public AnimationCurve slowCurve;

	private TimeManager.TimeEffectState _effectState;

	private float _elapsedTime;

	private int _slowLevel;

	private bool _isSlowRunning;

	private bool _paused;

	private float _curTimeScale;

	private float _goalTimeScale;

	private float _slowFactor;

	private int _timeLevelInBattle;

	public static TimeManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pause()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Resume()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCurTimeScale(float timeScale)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTimeLevel(int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeLevel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SlowMotion(float slowTime, float fastTime, bool zoom)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SlowRoutine(float slowTime, float fastTime, bool zoom)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EffectOff()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateSlowCurve()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetFixedTimeInBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetOriginalFixedTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetTimeScaleInBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetOriginalTimeFactor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetSlowFixedTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetSlowFixedTimeFactor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetSlowFactor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetTimeLevelFixedTimeFactor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetTimeLevelFactor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SlowEffectOn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PauseTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResumeTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetUITime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetUIDeltaTime()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TimeManager()
	{
		throw null;
	}

	public enum TimeEffectState
	{
		None,
		SlowCurve
	}
}
