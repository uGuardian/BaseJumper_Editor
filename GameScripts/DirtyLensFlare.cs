using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Max P/Dirty Lens Flare")]
public class DirtyLensFlare : MonoBehaviour
{
	public LensFlareTypes lensFlareType;

	public float saturation;

	public float threshold;

	public float flareIntensity;

	public float bloomIntensity;

	public int iterations;

	public float blurSpread;

	public int downsample;

	public bool useDirt;

	public Texture2D screenDirt;

	private Shader blurShader;

	private Material blurMaterial;

	private Shader shader;

	private Material m_Material;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Start()
	{
		throw null;
	}

	protected Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration, Material blurMtl)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyBlurPass(RenderTexture source, RenderTexture destination, Material blurMtl)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckResources()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DirtyLensFlare()
	{
		throw null;
	}
}
