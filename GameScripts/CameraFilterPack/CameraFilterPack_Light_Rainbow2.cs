﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Light/Rainbow2")]
public class CameraFilterPack_Light_Rainbow2 : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0.01f, 5f)]
	public float Value;

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
	public CameraFilterPack_Light_Rainbow2()
	{
		throw null;
	}
}
