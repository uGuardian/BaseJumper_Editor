using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class CameraFilterCustom_Snow : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 100f)]
	public float _FixDistance;

	[Range(-0.5f, 0.99f)]
	public float Snow_Near;

	[Range(0f, 1f)]
	public float Snow_Far;

	[Range(0f, 1f)]
	public float Fade;

	[Range(0f, 2f)]
	public float Intensity;

	[Range(0.4f, 2f)]
	public float Size;

	[Range(0f, 0.5f)]
	public float Speed;

	[Range(-5f, 5f)]
	public float SpeedX;

	[Range(0f, 1f)]
	public float SnowWithoutObject;

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
	public CameraFilterCustom_Snow()
	{
		throw null;
	}
}
