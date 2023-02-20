using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BattleCharacterProfile;
using UnityEngine;
using UnityEngine.UI;

public class BattleEmotionCoinSlotUI : MonoBehaviour
{
	private const float _minCameraSize = 10f;

	private const float _maxCameraSize = 40f;

	private const float _minSinFactor = 0.05f;

	private const float _maxSinFactor = 1f;

	private const float _camInterval = 30f;

	public Animator animCTRL;

	private AnimationCurve _cos;

	private AnimationCurve _sin;

	private float _sinFactor;

	private float _cosFactor;

	public RectTransform rect;

	public Image Icon;

	public Image Effect;

	private RectTransform dest;

	private Camera pivotCam;

	private RectTransform pivotCanvas;

	public Sprite Positive;

	public Sprite Negative;

	public Color Pos_Color;

	public Color Neg_Color;

	public ParticleSystem Emit;

	public ParticleSystem Trail;

	private float duration;

	private BattleUnitModel unit;

	private bool isPositive;

	private BattleCharacterProfileUI ui;

	private float _cameraFactor;

	private float _elapsedDestoryForcely;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float CalcSinFactor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Vector2 inital, AnimationCurve cos, AnimationCurve sin, BattleEmotionCoinUI.BattleEmotionCoinData data, Camera pivotCamera, RectTransform canvasRect, bool isPositive, float duration, BattleUnitModel unit, float cameraFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCoinTexture(bool isPositive)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator Moving(float maxTime, Vector2 startPos, Vector2 destPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMoving(float duration)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAppeared()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCompeleteAcquire()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionCoinSlotUI()
	{
		throw null;
	}
}
