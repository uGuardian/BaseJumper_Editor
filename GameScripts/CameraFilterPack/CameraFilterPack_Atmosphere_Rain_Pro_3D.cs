using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro_3D")]
public class CameraFilterPack_Atmosphere_Rain_Pro_3D : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 100f)]
	public float _FixDistance;

	[Range(0f, 1f)]
	public float Fade;

	[Range(0f, 2f)]
	public float Intensity;

	public bool DirectionFollowCameraZ;

	[Range(-0.45f, 0.45f)]
	public float DirectionX;

	[Range(0.4f, 2f)]
	public float Size;

	[Range(0f, 0.5f)]
	public float Speed;

	[Range(0f, 0.5f)]
	public float Distortion;

	[Range(0f, 1f)]
	public float StormFlashOnOff;

	[Range(0f, 1f)]
	public float DropOnOff;

	[Range(-0.5f, 0.99f)]
	public float Drop_Near;

	[Range(0f, 1f)]
	public float Drop_Far;

	[Range(0f, 1f)]
	public float Drop_With_Obj;

	[Range(0f, 1f)]
	public float Myst;

	[Range(0f, 1f)]
	public float Drop_Floor_Fluid;

	public Color Myst_Color;

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
	public CameraFilterPack_Atmosphere_Rain_Pro_3D()
	{
		throw null;
	}
}
