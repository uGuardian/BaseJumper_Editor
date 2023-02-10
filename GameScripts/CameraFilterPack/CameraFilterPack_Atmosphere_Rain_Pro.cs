using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro")]
public class CameraFilterPack_Atmosphere_Rain_Pro : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float Fade;

	[Range(0f, 2f)]
	public float Intensity;

	[Range(-0.25f, 0.25f)]
	public float DirectionX;

	[Range(0.4f, 2f)]
	public float Size;

	[Range(0f, 0.5f)]
	public float Speed;

	[Range(0f, 0.5f)]
	public float Distortion;

	[Range(0f, 1f)]
	public float StormFlashOnOff;

	[Range(0f, 1f)]
	public float DropOnOff;

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
	public CameraFilterPack_Atmosphere_Rain_Pro()
	{
		throw null;
	}
}
