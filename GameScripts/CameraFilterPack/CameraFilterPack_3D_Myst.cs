using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Myst")]
public class CameraFilterPack_3D_Myst : MonoBehaviour
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

	[Range(0f, 10f)]
	public float DistortionLevel;

	[Range(0.1f, 10f)]
	public float DistortionSize;

	[Range(-2f, 4f)]
	public float LightIntensity;

	public bool AutoAnimatedNear;

	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed;

	private Texture2D Texture2;

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
	public CameraFilterPack_3D_Myst()
	{
		throw null;
	}
}
