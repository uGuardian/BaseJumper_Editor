using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Blood_Plus")]
public class CameraFilterPack_AAA_Blood_Plus : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0f, 1f)]
	public float Blood_1;

	[Range(0f, 1f)]
	public float Blood_2;

	[Range(0f, 1f)]
	public float Blood_3;

	[Range(0f, 1f)]
	public float Blood_4;

	[Range(0f, 1f)]
	public float Blood_5;

	[Range(0f, 1f)]
	public float Blood_6;

	[Range(0f, 1f)]
	public float Blood_7;

	[Range(0f, 1f)]
	public float Blood_8;

	[Range(0f, 1f)]
	public float Blood_9;

	[Range(0f, 1f)]
	public float Blood_10;

	[Range(0f, 1f)]
	public float Blood_11;

	[Range(0f, 1f)]
	public float Blood_12;

	[Range(0f, 1f)]
	public float LightReflect;

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
	public CameraFilterPack_AAA_Blood_Plus()
	{
		throw null;
	}
}
