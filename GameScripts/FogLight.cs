using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class FogLight : LightOverride
{
	private CommandBuffer m_BufGrabShadowmap;

	private CommandBuffer m_BufGrabShadowParams;

	private RenderTexture m_Shadowmap;

	private ComputeBuffer m_ShadowParamsCB;

	public Shader m_BlurShadowmapShader;

	private Material m_BlurShadowmapMaterial;

	public Shader m_CopyShadowParamsShader;

	private Material m_CopyShadowParamsMaterial;

	private int[] temp;

	public bool m_ForceOnForFog;

	[Tooltip("Only one shadowed fog AreaLight at a time.")]
	[Header("Shadows")]
	public bool m_Shadows;

	[Tooltip("Always at most half the res of the AreaLight's shadowmap.")]
	public FogLight.TextureSize m_ShadowmapRes;

	[Range(0f, 3f)]
	public int m_BlurIterations;

	[MinValue(0f)]
	public float m_BlurSize;

	[MinValue(0f)]
	[Tooltip("Affects shadow softness.")]
	public float m_ESMExponent;

	public bool m_Bounded;

	private bool m_AddedToLightManager;

	private bool directionalShadow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDirectionalShadowmap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDirectionalShadowmap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CleanupDirectionalShadowmap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetUpDirectionalShadowmapForSampling(bool shadows, ComputeShader cs, int kernel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseTemporary(ref RenderTexture rt)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool GetForceOn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddToLightManager()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
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
	public FogLight()
	{
		throw null;
	}

	public enum TextureSize
	{
		x256 = 256,
		x512 = 512,
		x1024 = 1024
	}
}
