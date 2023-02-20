using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_TheHead_Shockwave : FarAreaEffect
{
	[SerializeField]
	private AudioClip _castingSound;

	[SerializeField]
	private AudioClip _cutSceneStartSound;

	[SerializeField]
	private AudioClip _cutSceneEndSound;

	[SerializeField]
	private AudioClip _boomSound;

	[SerializeField]
	private GameObject _castingEffectRes;

	[SerializeField]
	private GameObject _atkEffectRes;

	[SerializeField]
	private GameObject _castingDoneEffectRes;

	[SerializeField]
	private SpriteRenderer _cutSceneStartRenderer;

	[SerializeField]
	private AnimationCurve _fadeOutCurve;

	[SerializeField]
	private SpriteRenderer _cutSceneEndRenderer;

	[SerializeField]
	private AnimationCurve _fadeInCurve;

	[SerializeField]
	private float _fadeSpeed;

	[SerializeField]
	private float _castingDelay;

	[SerializeField]
	private float _fadeDelay;

	[SerializeField]
	private float _atkBeforeDelay;

	[SerializeField]
	private float _atkDelay;

	[SerializeField]
	private float _atkEarthQuakeSpeed;

	[SerializeField]
	private AnimationCurve _atkEarthQuakeCurve;

	private float _elapsed;

	private float _elapsedAtkEarthQuake;

	private float _elapsedFade;

	private FarAreaEffect_TheHead_Shockwave.Phase _phase;

	private CameraFilterPack_FX_EarthQuake _earthQuakeFilter;

	private string _defaultCharacterLayerName;

	private string _defaultCharacterUILayerName;

	private bool _bDoneFade;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeAlpha(SpriteRenderer r, float a)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReviseSpriteRenderer(SpriteRenderer r)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCrator()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetShockwave()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_TheHead_Shockwave()
	{
		throw null;
	}

	public enum Phase
	{
		Casting,
		CutScene,
		AtkBefore,
		Atk,
		None
	}
}
