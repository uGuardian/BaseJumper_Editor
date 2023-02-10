using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Split Screen/SideBySide")]
public class CameraFilterPack_Blend2Camera_SplitScreen : MonoBehaviour
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

	[Range(-3f, 3f)]
	public float SplitX;

	[Range(-3f, 3f)]
	public float SplitY;

	[Range(0f, 2f)]
	public float Smooth;

	[Range(-3.14f, 3.14f)]
	public float Rotation;

	private bool ForceYSwap;

	private RenderTexture Camera2tex;

	private Vector2 ScreenSize;

	private Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
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
	public CameraFilterPack_Blend2Camera_SplitScreen()
	{
		throw null;
	}
}
