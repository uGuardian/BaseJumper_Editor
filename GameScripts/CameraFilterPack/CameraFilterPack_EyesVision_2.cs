using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Eyes 2")]
public class CameraFilterPack_EyesVision_2 : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(1f, 32f)]
	public float _EyeWave;

	[Range(0f, 10f)]
	public float _EyeSpeed;

	[Range(0f, 8f)]
	public float _EyeMove;

	[Range(0f, 1f)]
	public float _EyeBlink;

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
	public CameraFilterPack_EyesVision_2()
	{
		throw null;
	}
}
