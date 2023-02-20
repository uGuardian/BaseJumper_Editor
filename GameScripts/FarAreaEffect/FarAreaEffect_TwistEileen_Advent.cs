using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_TwistEileen_Advent : FarAreaEffect
{
	[SerializeField]
	private GameObject effect;

	[SerializeField]
	private UIAnimationEventHandler eventHandler;

	public float currentunitheight;

	[SerializeField]
	private AnimationCurve startheightcurve;

	[SerializeField]
	private AnimationCurve unfoldwingheightcurve;

	[SerializeField]
	private AnimationCurve stopcurve;

	private readonly string _PREFAB_PATH_SkyLight;

	private readonly string _PREFAB_PATH_BackLight;

	private GameObject skyLightEffect;

	private GameObject backLightEffect;

	private FarAreaEffect_TwistEileen_Advent.EileenAdventState currentstate;

	private float timer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveBackLight()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveSkyLight()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopFly()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDefaultMotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Destroythis()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_TwistEileen_Advent()
	{
		throw null;
	}

	private enum EileenAdventState
	{
		Start,
		UnfoldWing,
		STOP
	}
}
