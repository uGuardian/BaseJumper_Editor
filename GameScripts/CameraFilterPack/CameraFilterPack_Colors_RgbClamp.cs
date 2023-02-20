using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Colors/RgbClamp")]
public class CameraFilterPack_Colors_RgbClamp : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float Red_Start;

	[Range(0f, 1f)]
	public float Red_End;

	[Range(0f, 1f)]
	public float Green_Start;

	[Range(0f, 1f)]
	public float Green_End;

	[Range(0f, 1f)]
	public float Blue_Start;

	[Range(0f, 1f)]
	public float Blue_End;

	[Range(0f, 1f)]
	public float RGB_Start;

	[Range(0f, 1f)]
	public float RGB_End;

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
	public CameraFilterPack_Colors_RgbClamp()
	{
		throw null;
	}
}
