using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Drunk")]
public class CameraFilterPack_FX_Drunk : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[HideInInspector]
	[Range(0f, 20f)]
	public float Value;

	[Range(0f, 10f)]
	public float Speed;

	[Range(0f, 1f)]
	public float Wavy;

	[Range(0f, 1f)]
	public float Distortion;

	[Range(0f, 1f)]
	public float DistortionWave;

	[Range(0f, 1f)]
	public float Fade;

	[Range(-2f, 2f)]
	public float ColoredSaturate;

	[Range(-1f, 2f)]
	public float ColoredChange;

	[Range(-1f, 1f)]
	public float ChangeRed;

	[Range(-1f, 1f)]
	public float ChangeGreen;

	[Range(-1f, 1f)]
	public float ChangeBlue;

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
	public CameraFilterPack_FX_Drunk()
	{
		throw null;
	}
}
