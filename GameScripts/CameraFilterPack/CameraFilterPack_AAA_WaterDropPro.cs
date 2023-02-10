using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/WaterDropPro")]
public class CameraFilterPack_AAA_WaterDropPro : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(8f, 64f)]
	public float Distortion;

	[Range(0f, 7f)]
	public float SizeX;

	[Range(0f, 7f)]
	public float SizeY;

	[Range(0f, 10f)]
	public float Speed;

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
	public CameraFilterPack_AAA_WaterDropPro()
	{
		throw null;
	}
}
