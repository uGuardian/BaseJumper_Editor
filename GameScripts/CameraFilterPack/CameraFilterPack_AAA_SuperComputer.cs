using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Super Computer")]
public class CameraFilterPack_AAA_SuperComputer : MonoBehaviour
{
	public Shader SCShader;

	[Range(0f, 1f)]
	public float _AlphaHexa;

	private float TimeX;

	private Material SCMaterial;

	[Range(-20f, 20f)]
	public float ShapeFormula;

	[Range(0f, 6f)]
	public float Shape;

	[Range(-4f, 4f)]
	public float _BorderSize;

	public Color _BorderColor;

	public float _SpotSize;

	public Vector2 center;

	public float Radius;

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
	public CameraFilterPack_AAA_SuperComputer()
	{
		throw null;
	}
}
