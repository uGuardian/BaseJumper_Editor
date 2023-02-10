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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pause()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Resume()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCurTimeScale(float timeScale)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateTime()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTimeLevel(int level)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTimeLevel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SlowMotion(float slowTime, float fastTime, bool zoom)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SlowRoutine(float slowTime, float fastTime, bool zoom)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EffectOff()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateSlowCurve()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PauseTime()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResumeTime()
	{
		
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
