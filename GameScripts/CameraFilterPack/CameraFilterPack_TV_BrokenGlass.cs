using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Broken Glass")]
public class CameraFilterPack_TV_BrokenGlass : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0f, 128f)]
	public float Broken_Small;

	[Range(0f, 128f)]
	public float Broken_Medium;

	[Range(0f, 128f)]
	public float Broken_High;

	[Range(0f, 128f)]
	public float Broken_Big;

	[Range(0f, 0.004f)]
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
	public CameraFilterPack_TV_BrokenGlass()
	{
		throw null;
	}
}
