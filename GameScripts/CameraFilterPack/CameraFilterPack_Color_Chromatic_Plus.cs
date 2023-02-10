using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Colors/Chromatic_Plus")]
public class CameraFilterPack_Color_Chromatic_Plus : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 0.8f)]
	public float Size;

	[Range(0.01f, 0.4f)]
	public float Smooth;

	[Range(-0.02f, 0.02f)]
	public float Offset;

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
	public CameraFilterPack_Color_Chromatic_Plus()
	{
		throw null;
	}
}
