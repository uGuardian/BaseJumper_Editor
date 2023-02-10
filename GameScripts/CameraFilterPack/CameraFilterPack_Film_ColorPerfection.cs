﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Film/ColorPerfection")]
public class CameraFilterPack_Film_ColorPerfection : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 4f)]
	public float Gamma;

	[Range(0f, 10f)]
	private float Value2;

	[Range(0f, 10f)]
	private float Value3;

	[Range(0f, 10f)]
	private float Value4;

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
	public CameraFilterPack_Film_ColorPerfection()
	{
		throw null;
	}
}
