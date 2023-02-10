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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveBackLight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActiveSkyLight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopFly()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeDefaultMotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Destroythis()
	{
		throw null;
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
