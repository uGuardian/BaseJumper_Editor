﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Old Film/Cutting 2")]
public class CameraFilterPack_OldFilm_Cutting2 : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0f, 10f)]
	public float Speed;

	[Range(0f, 2f)]
	public float Luminosity;

	[Range(0f, 1f)]
	public float Vignette;

	[Range(0f, 1f)]
	public float Negative;

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
	public CameraFilterPack_OldFilm_Cutting2()
	{
		throw null;
	}
}
