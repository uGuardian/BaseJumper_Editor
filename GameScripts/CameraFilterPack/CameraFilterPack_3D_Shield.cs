using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Shield")]
public class CameraFilterPack_3D_Shield : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 100f)]
	public float _FixDistance;

	[Range(-0.99f, 0.99f)]
	public float _Distance;

	[Range(0f, 0.5f)]
	public float _Size;

	[Range(0f, 1f)]
	public float _FadeShield;

	[Range(-0.2f, 0.2f)]
	public float LightIntensity;

	public bool AutoAnimatedNear;

	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed;

	[Range(0f, 10f)]
	public float Speed;

	[Range(0f, 10f)]
	public float Speed_X;

	[Range(0f, 1f)]
	public float Speed_Y;

	[Range(0f, 10f)]
	public float Intensity;

	public static Color ChangeColorRGB;

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
	public CameraFilterPack_3D_Shield()
	{
		throw null;
	}
}
