using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/SniperScore")]
public class CameraFilterPack_Vision_SniperScore : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float Fade;

	[Range(0f, 1f)]
	public float Size;

	[Range(0.01f, 0.4f)]
	public float Smooth;

	[Range(0f, 1f)]
	public float _Cible;

	[Range(0f, 1f)]
	public float _Distortion;

	[Range(0f, 1f)]
	public float _ExtraColor;

	[Range(0f, 1f)]
	public float _ExtraLight;

	public Color _Tint;

	[Range(0f, 10f)]
	private float StretchX;

	[Range(0f, 10f)]
	private float StretchY;

	[Range(-1f, 1f)]
	public float _PosX;

	[Range(-1f, 1f)]
	public float _PosY;

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
	public CameraFilterPack_Vision_SniperScore()
	{
		throw null;
	}
}
