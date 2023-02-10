using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleEffectLayer : MonoBehaviour
{
	private static BattleEffectLayer _instance;

	private List<TimeScalableEffect> _effectList;

	private float _globalEffectTimeScale;

	public static BattleEffectLayer instance
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
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFixedUpdate(float deltaTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTimeScale(float timeScale)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEffectLayer()
	{
		throw null;
	}
}
