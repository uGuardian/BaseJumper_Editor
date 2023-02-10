using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class VolumetricFog : MonoBehaviour
{
	private Material m_DebugMaterial;

	[HideInInspector]
	public Shader m_DebugShader;

	[HideInInspector]
	public Shader m_ShadowmapShader;

	[HideInInspector]
	public ComputeShader m_InjectLightingAndDensity;

	[HideInInspector]
	public ComputeShader m_Scatter;

	private Material m_ApplyToOpaqueMaterial;

	[HideInInspector]
	public Shader m_ApplyToOpaqueShader;

	private Material m_BlurShadowmapMaterial;

	[HideInInspector]
	public Shader m_BlurShadowmapShader;

	[HideInInspector]
	public Texture2D m_Noise;

	[HideInInspector]
	public bool m_Debug;

	[HideInInspector]
	[Range(0f, 1f)]
	public float m_Z;

	[Header("Size")]
	[MinValue(0.1f)]
	public float m_NearClip;

	[MinValue(0.1f)]
	public float m_FarClipMax;

	[Header("Fog Density")]
	[FormerlySerializedAs("m_Density")]
	public float m_GlobalDensityMult;

	private VolumetricFog.Vector3i m_InjectNumThreads;

	private VolumetricFog.Vector3i m_ScatterNumThreads;

	private RenderTexture m_VolumeInject;

	private RenderTexture m_VolumeScatter;

	private VolumetricFog.Vector3i m_VolumeResolution;

	private Camera m_Camera;

	public float m_ConstantFog;

	public float m_HeightFogAmount;

	public float m_HeightFogExponent;

	public float m_HeightFogOffset;

	[Tooltip("Noise multiplies with constant fog and height fog, but not with fog ellipsoids.")]
	[Range(0f, 1f)]
	public float m_NoiseFogAmount;

	public float m_NoiseFogScale;

	public Wind m_Wind;

	[Range(0f, 0.999f)]
	public float m_Anisotropy;

	[Header("Lights")]
	[FormerlySerializedAs("m_Intensity")]
	public float m_GlobalIntensityMult;

	[MinValue(0f)]
	public float m_AmbientLightIntensity;

	public Color m_AmbientLightColor;

	private VolumetricFog.PointLightParams[] m_PointLightParams;

	private ComputeBuffer m_PointLightParamsCB;

	private VolumetricFog.TubeLightParams[] m_TubeLightParams;

	private ComputeBuffer m_TubeLightParamsCB;

	private VolumetricFog.TubeLightShadowPlaneParams[] m_TubeLightShadowPlaneParams;

	private ComputeBuffer m_TubeLightShadowPlaneParamsCB;

	private VolumetricFog.AreaLightParams[] m_AreaLightParams;

	private ComputeBuffer m_AreaLightParamsCB;

	private VolumetricFog.FogEllipsoidParams[] m_FogEllipsoidParams;

	private ComputeBuffer m_FogEllipsoidParamsCB;

	private ComputeBuffer m_DummyCB;

	private TubeLightShadowPlane.Params[] sppArr;

	private FogLight m_DirectionalLight;

	private float[] m_dirLightColor;

	private float[] m_dirLightDir;

	private float[] m_fogParams;

	private float[] m_windDir;

	private float[] m_ambientLight;

	private static readonly Vector2[] frustumUVs;

	private static float[] frustumRays;

	private Camera cam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private float nearClip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private float farClip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseComputeBuffer(ref ComputeBuffer buffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Cleanup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SanitizeInput()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpPointLightBuffers(int kernel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpTubeLightBuffers(int kernel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpAreaLightBuffers(int kernel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpFogEllipsoidBuffers(int kernel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FogLight GetDirectionalLight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreRender()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpDirectionalLight(int kernel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpForScatter(int kernel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Scatter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DebugDisplay(RenderTexture src, RenderTexture dest)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpGlobalFogSamplingUniforms(int width, int height)
	{
		throw null;
	}

	[ImageEffectOpaque]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPostRender()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VolumetricFogInForward(bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 ViewportToLocalPoint(Camera c, Transform t, Vector3 p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetFrustumRays()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitVolume(ref RenderTexture volume)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateBuffer(ref ComputeBuffer buffer, int count, int stride)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitResources()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseTemporary(ref RenderTexture rt)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitMaterial(ref Material material, Shader shader)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckSupport()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetUnsupportedErrorMessage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VolumetricFog()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VolumetricFog()
	{
		throw null;
	}

	private struct Vector3i
	{
		public int x;

		public int y;

		public int z;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3i(int x, int y, int z)
		{
			throw null;
		}
	}

	private struct PointLightParams
	{
		public Vector3 pos;

		public float range;

		public Vector3 color;

		private float padding;
	}

	private struct TubeLightParams
	{
		public Vector3 start;

		public float range;

		public Vector3 end;

		public float radius;

		public Vector3 color;

		private float padding;
	}

	private struct TubeLightShadowPlaneParams
	{
		public Vector4 plane0;

		public Vector4 plane1;

		public float feather0;

		public float feather1;

		private float padding0;

		private float padding1;
	}

	private struct AreaLightParams
	{
		public Matrix4x4 mat;

		public Vector4 pos;

		public Vector3 color;

		public float bounded;
	}

	private struct FogEllipsoidParams
	{
		public Vector3 pos;

		public float radius;

		public Vector3 axis;

		public float stretch;

		public float density;

		public float noiseAmount;

		public float noiseSpeed;

		public float noiseScale;

		public float feather;

		public float blend;

		public float padding1;

		public float padding2;
	}
}
