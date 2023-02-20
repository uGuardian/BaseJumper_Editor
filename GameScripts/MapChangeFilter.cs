using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MapChangeFilter : MonoBehaviour
{
	public Camera[] camAry;

	public Camera myCam;

	[SerializeField]
	private float _fadeSpeed;

	[SerializeField]
	private AnimationCurve _fadeCurve;

	[SerializeField]
	private AnimationCurve _fadeCurveUpDown;

	private RenderTexture _rt;

	private Texture2D _tex;

	private Sprite _spr;

	[SerializeField]
	private GameObject _particleObj;

	private float _elapsedParticleArrived;

	private bool _bParticleArrived;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMapChangingEffect(Direction fadeOutStartDir, bool particleOn = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CaptureMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateTexture()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateSprite()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutRoutine(Direction fadeOutStartDir, bool particleOn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseSprite()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseTexture()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseRenderTexture()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapChangeFilter()
	{
		throw null;
	}
}
