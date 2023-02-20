using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BS3_Combo_Common : MonoBehaviour
{
	[SerializeField]
	protected SpriteRenderer _spr;

	[SerializeField]
	protected GameObject _atkEffect;

	[SerializeField]
	protected _2dxFX_DesintegrationFX _sprEffect;

	[SerializeField]
	protected AnimationCurve _sprEffectCurve;

	[SerializeField]
	protected float _sprEffectSpeed;

	protected float _elapedSprEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BS3_Combo_Common()
	{
		throw null;
	}
}
