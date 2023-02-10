using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/BluePrint")]
public class CameraFilterPack_Drawing_BluePrint : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	public Color Pencil_Color;

	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size;

	[Range(0f, 2f)]
	public float Pencil_Correction;

	[Range(0f, 1f)]
	public float Intensity;

	[Range(0f, 2f)]
	public float Speed_Animation;

	[Range(0f, 1f)]
	public float Corner_Lose;

	[Range(0f, 1f)]
	public float Fade_Paper_to_BackColor;

	[Range(0f, 1f)]
	public float Fade_With_Original;

	public Color Back_Color;

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
	public CameraFilterPack_Drawing_BluePrint()
	{
		throw null;
	}
}
