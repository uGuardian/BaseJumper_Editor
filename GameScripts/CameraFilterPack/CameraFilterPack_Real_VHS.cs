using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/VHS/Real VHS HQ")]
public class CameraFilterPack_Real_VHS : MonoBehaviour
{
	public Shader SCShader;

	private Material SCMaterial;

	private Texture2D VHS;

	private Texture2D VHS2;

	[Range(0f, 1f)]
	public float TRACKING;

	[Range(0f, 1f)]
	public float JITTER;

	[Range(0f, 1f)]
	public float GLITCH;

	[Range(0f, 1f)]
	public float NOISE;

	[Range(-1f, 1f)]
	public float Brightness;

	[Range(0f, 1.5f)]
	public float Constrast;

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
	public static Texture2D GetRTPixels(Texture2D t, RenderTexture rt, int sx, int sy)
	{
		throw null;
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
	public CameraFilterPack_Real_VHS()
	{
		throw null;
	}
}
