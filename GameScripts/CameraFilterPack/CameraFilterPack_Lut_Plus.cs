﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/Plus")]
public class CameraFilterPack_Lut_Plus : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Vector4 ScreenResolution;

	private Material SCMaterial;

	public Texture2D LutTexture;

	private Texture3D converted3DLut;

	[Range(0f, 1f)]
	public float Blend;

	private string MemoPath;

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
	public void SetIdentityLut()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ValidDimensions(Texture2D tex2d)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Convert(Texture2D temp2DTex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
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
	public CameraFilterPack_Lut_Plus()
	{
		throw null;
	}
}