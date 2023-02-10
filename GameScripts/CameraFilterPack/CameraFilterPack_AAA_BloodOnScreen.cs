using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Blood On Screen")]
public class CameraFilterPack_AAA_BloodOnScreen : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0.02f, 1.6f)]
	public float Blood_On_Screen;

	public Color Blood_Color;

	[Range(0f, 2f)]
	public float Blood_Intensify;

	[Range(0f, 2f)]
	public float Blood_Darkness;

	[Range(0f, 1f)]
	public float Blood_Distortion_Speed;

	[Range(0f, 1f)]
	public float Blood_Fade;

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
	public CameraFilterPack_AAA_BloodOnScreen()
	{
		throw null;
	}
}
