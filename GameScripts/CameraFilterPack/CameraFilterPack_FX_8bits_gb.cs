﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Pixel/8bits_gb")]
public class CameraFilterPack_FX_8bits_gb : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(-1f, 1f)]
	public float Brightness;

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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraFilterPack_FX_8bits_gb()
	{
		throw null;
	}
}
