﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Distortion/Dream")]
public class CameraFilterPack_Distortion_Dream : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(1f, 10f)]
	public float Distortion;

	private Material SCMaterial;

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
	public CameraFilterPack_Distortion_Dream()
	{
		throw null;
	}
}
