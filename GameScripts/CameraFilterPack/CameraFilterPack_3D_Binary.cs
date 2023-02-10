using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Binary")]
public class CameraFilterPack_3D_Binary : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	public bool _Visualize;

	private Material SCMaterial;

	[Range(0f, 100f)]
	public float _FixDistance;

	[Range(-5f, 5f)]
	public float LightIntensity;

	[Range(0f, 8f)]
	public float MatrixSize;

	[Range(-4f, 4f)]
	public float MatrixSpeed;

	[Range(0f, 1f)]
	public float Fade;

	[Range(0f, 1f)]
	public float FadeFromBinary;

	public Color _MatrixColor;

	public static Color ChangeColorRGB;

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
	public CameraFilterPack_3D_Binary()
	{
		throw null;
	}
}
