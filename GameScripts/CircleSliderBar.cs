using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CircleSliderBar : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	private RectTransform rect_Gauge;

	[SerializeField]
	private RectTransform rect_EffectGauge;

	public Image img_bar;

	private Animator anim;

	private float maxValue;

	private float currentValue;

	private float targetValue;

	private bool isRunningValueLerp;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void inits(float maxv, float currentv)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetValue(int _targetValue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetData(int _targetValue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator HPLerpProcess()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CircleSliderBar()
	{
		throw null;
	}
}
