using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/BlackHole")]
public class CameraFilterPack_3D_BlackHole : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	public bool _Visualize;

	private Material SCMaterial;

	[Range(0f, 100f)]
	public float _FixDistance;

	[Range(-0.99f, 0.99f)]
	public float _Distance;

	[Range(0f, 1f)]
	public float _Size;

	[Range(-2f, 2f)]
	public float DistortionLevel;

	[Range(0f, 1f)]
	public float DistortionSize;

	public bool AutoAnimatedNear;

	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed;

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
	public CameraFilterPack_3D_BlackHole()
	{
		throw null;
	}
}
