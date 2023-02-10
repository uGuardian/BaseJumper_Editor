using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_UVAnimation : MonoBehaviour
{
	public int TilesX;

	public int TilesY;

	public int FPS;

	public int StartFrameOffset;

	public bool IsLoop;

	public float StartDelay;

	public bool IsReverse;

	public bool IsInterpolateFrames;

	public RFX4_TextureShaderProperties[] TextureNames;

	public AnimationCurve FrameOverTime;

	private int count;

	private Renderer currentRenderer;

	private Projector projector;

	private Material instanceMaterial;

	private float animationStartTime;

	private bool canUpdate;

	private int previousIndex;

	private int totalFrames;

	private float currentInterpolatedTime;

	private int currentIndex;

	private Vector2 size;

	private bool isInitialized;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDefaultVariables()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeMaterial()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMaterial()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSpriteAnimation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSpriteAnimationIterpolated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_UVAnimation()
	{
		throw null;
	}
}
