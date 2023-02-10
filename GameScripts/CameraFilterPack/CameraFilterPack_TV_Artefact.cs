using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Artefact")]
public class CameraFilterPack_TV_Artefact : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0f, 1f)]
	public float Fade;

	[Range(-10f, 10f)]
	public float Colorisation;

	[Range(-10f, 10f)]
	public float Parasite;

	[Range(-10f, 10f)]
	public float Noise;

	private Material SCMaterial;

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
	public CameraFilterPack_TV_Artefact()
	{
		throw null;
	}
}
