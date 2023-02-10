using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FinalEpisode_Lose : MonoBehaviour
{
	[SerializeField]
	private AudioClip _castingSound;

	[SerializeField]
	private AudioClip _cutSceneStartSound;

	[SerializeField]
	private GameObject _castingEffectRes;

	[SerializeField]
	private SpriteRenderer _cutSceneStartRenderer;

	[SerializeField]
	private SpriteRenderer _cutSceneEndRenderer;

	[SerializeField]
	private AnimationCurve _fadeInCurve;

	private float _castingDelay;

	private float _fadeSpeed;

	private float _fadeDelay;

	private float _elapsed;

	private float _elapsedFade;

	private float _elapsedCastDelay;

	private bool _bDoneFade;

	private bool _bInit;

	private bool _bEnd;

	private FinalEpisode_Lose.Phase _phase;

	private Action _callback;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Action completeCallback)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
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
	public FinalEpisode_Lose()
	{
		throw null;
	}

	public enum Phase
	{
		Casting,
		CutScene
	}
}
