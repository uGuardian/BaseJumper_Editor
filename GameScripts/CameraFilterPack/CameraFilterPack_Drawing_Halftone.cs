﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Halftone")]
public class CameraFilterPack_Drawing_Halftone : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float Threshold;

	[Range(1f, 16f)]
	public float DotSize;

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
	public CameraFilterPack_Drawing_Halftone()
	{
		throw null;
	}
}