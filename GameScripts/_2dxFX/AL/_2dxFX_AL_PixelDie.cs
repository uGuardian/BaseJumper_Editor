﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Advanced Lightning/PixelDie")]
[Serializable]
public class _2dxFX_AL_PixelDie : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	[HideInInspector]
	public bool AddShadow;

	[HideInInspector]
	public bool ReceivedShadow;

	[HideInInspector]
	public int BlendMode;

	private string shader;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha;

	[HideInInspector]
	public Texture2D __MainTex2;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Value1;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Value2;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Value3;

	[HideInInspector]
	public float _Value4;

	[HideInInspector]
	public bool _AutoScrollX;

	[HideInInspector]
	[Range(0f, 10f)]
	public float _AutoScrollSpeedX;

	[HideInInspector]
	public bool _AutoScrollY;

	[HideInInspector]
	[Range(0f, 10f)]
	public float _AutoScrollSpeedY;

	[HideInInspector]
	private float _AutoScrollCountX;

	[HideInInspector]
	private float _AutoScrollCountY;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

	private SpriteRenderer CanvasSpriteRenderer;

	[HideInInspector]
	public bool ActiveUpdate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _2dxFX_AL_PixelDie()
	{
		throw null;
	}
}
