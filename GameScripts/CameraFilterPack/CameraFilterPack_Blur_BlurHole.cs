using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/Blur Hole")]
public class CameraFilterPack_Blur_BlurHole : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(1f, 16f)]
	public float Size;

	[Range(-1f, 1f)]
	public float _Radius;

	[Range(-4f, 4f)]
	public float _SpotSize;

	[Range(0f, 1f)]
	public float _CenterX;

	[Range(0f, 1f)]
	public float _CenterY;

	[Range(0f, 1f)]
	public float _AlphaBlur;

	[Range(0f, 1f)]
	public float _AlphaBlurInside;

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
	public CameraFilterPack_Blur_BlurHole()
	{
		throw null;
	}
}
