using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Divide")]
public class CameraFilterPack_Blend2Camera_Divide : MonoBehaviour
{
	private string ShaderName;

	public Shader SCShader;

	public Camera Camera2;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX;

	private RenderTexture Camera2tex;

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
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraFilterPack_Blend2Camera_Divide()
	{
		throw null;
	}
}
