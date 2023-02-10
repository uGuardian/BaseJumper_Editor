using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("KriptoFX/RFX1_BloomAndDistortion")]
public class RFX4_DistortionAndBloom : MonoBehaviour
{
	[Range(0.05f, 1f)]
	[Tooltip("Camera render texture resolution")]
	public float RenderTextureResolutoinFactor;

	public bool UseBloom;

	[Range(0.1f, 3f)]
	[Tooltip("Filters out pixels under this level of brightness.")]
	public float Threshold;

	[SerializeField]
	[Range(0f, 1f)]
	[Tooltip("Makes transition between under/over-threshold gradual.")]
	public float SoftKnee;

	[Range(1f, 7f)]
	[Tooltip("Changes extent of veiling effects in A screen resolution-independent fashion.")]
	public float Radius;

	[Tooltip("Blend factor of the result image.")]
	public float Intensity;

	[Tooltip("Controls filter quality and buffer resolution.")]
	public bool HighQuality;

	[Tooltip("Reduces flashing noise with an additional filter.")]
	public bool AntiFlicker;

	private const string shaderName = "Hidden/KriptoFX/PostEffects/RFX4_Bloom";

	private const string shaderAdditiveName = "Hidden/KriptoFX/PostEffects/RFX4_BloomAdditive";

	private const string cameraName = "MobileCamera(Distort_Bloom_Depth)";

	private RenderTexture source;

	private RenderTexture depth;

	private RenderTexture destination;

	private int previuosFrameWidth;

	private int previuosFrameHeight;

	private float previousScale;

	private Camera addCamera;

	private GameObject tempGO;

	private bool HDRSupported;

	private Material m_Material;

	private Material m_MaterialAdditive;

	private const int kMaxIterations = 16;

	private readonly RenderTexture[] m_blurBuffer1;

	private readonly RenderTexture[] m_blurBuffer2;

	public Material mat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Material matAdditive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Material CheckShaderAndCreateMaterial(Shader s)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPostRender()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeRenderTarget()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateBloom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GrabImage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_DistortionAndBloom()
	{
		throw null;
	}
}
