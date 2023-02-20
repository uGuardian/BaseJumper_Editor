using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Eileen_StrengthBufEffect : MonoBehaviour
{
	[SerializeField]
	private Transform transform_circlespr;

	[SerializeField]
	private AnimationCurve _circleRotateCurve;

	[SerializeField]
	private AnimationCurve _circleAlpahCurve;

	[SerializeField]
	private AnimationCurve _bgAlpahCurve;

	[SerializeField]
	private AnimationCurve _blackbgAlpahCurve;

	[SerializeField]
	private SpriteRenderer spriterenderer_dummy;

	[SerializeField]
	private SpriteRenderer spriterenderer_circle;

	[SerializeField]
	private SpriteRenderer spriterenderer_bg;

	[SerializeField]
	private SpriteRenderer spriterenderer_blackBg;

	public float effectTime;

	public float endtime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Eileen_StrengthBufEffect()
	{
		throw null;
	}
}
