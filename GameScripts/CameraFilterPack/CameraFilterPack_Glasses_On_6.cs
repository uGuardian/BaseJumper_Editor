﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Spy")]
public class CameraFilterPack_Glasses_On_6 : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0f, 1f)]
	public float Fade;

	[Range(0f, 0.1f)]
	public float VisionBlur;

	public Color GlassesColor;

	public Color GlassesColor2;

	[Range(0f, 1f)]
	public float GlassDistortion;

	[Range(0f, 1f)]
	public float GlassAberration;

	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	[Range(0f, 1f)]
	public float UseScanLine;

	[Range(1f, 512f)]
	public float UseScanLineSize;

	public Color GlassColor;

	private Material SCMaterial;

	private Texture2D Texture2;

	private Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraFilterPack_Glasses_On_6()
	{
		throw null;
	}
}
