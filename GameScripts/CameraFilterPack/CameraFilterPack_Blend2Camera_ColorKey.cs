using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Chroma Key/Color Key")]
public class CameraFilterPack_Blend2Camera_ColorKey : MonoBehaviour
{
	private string ShaderName;

	public Shader SCShader;

	public Camera Camera2;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float BlendFX;

	public Color ColorKey;

	[Range(-0.2f, 0.2f)]
	public float Adjust;

	[Range(-0.2f, 0.2f)]
	public float Precision;

	[Range(-0.2f, 0.2f)]
	public float Luminosity;

	[Range(-0.3f, 0.3f)]
	public float Change_Red;

	[Range(-0.3f, 0.3f)]
	public float Change_Green;

	[Range(-0.3f, 0.3f)]
	public float Change_Blue;

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
	public CameraFilterPack_Blend2Camera_ColorKey()
	{
		throw null;
	}
}
