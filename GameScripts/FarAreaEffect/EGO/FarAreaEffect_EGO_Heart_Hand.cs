using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Heart_Hand : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer _floorSpr;

	[SerializeField]
	private List<_2dxFX_Blood> _bloodHandEffects;

	[SerializeField]
	private AnimationCurve _floorAlphaCurve;

	[SerializeField]
	private AnimationCurve _bloodCurve;

	[SerializeField]
	private AnimationCurve _bloodDistortionCurve;

	[SerializeField]
	private float _onSpeed;

	[SerializeField]
	private float _offSpeed;

	private float _elapsed;

	private FarAreaEffect_EGO_Heart_Hand.State _state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Off()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_Heart_Hand()
	{
		throw null;
	}

	public enum State
	{
		None,
		On,
		Off
	}
}
