﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Colors/Switching")]
public class CameraFilterPack_Color_Switching : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 5f)]
	public int Color;

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
	public CameraFilterPack_Color_Switching()
	{
		throw null;
	}
}
