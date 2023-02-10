using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class AreaLight : MonoBehaviour
{
	[HideInInspector]
	public Mesh m_Cube;

	[HideInInspector]
	public Shader m_ProxyShader;

	private Material m_ProxyMaterial;

	private static Texture2D s_TransformInvTexture_Specular;

	private static Texture2D s_TransformInvTexture_Diffuse;

	private static Texture2D s_AmpDiffAmpSpecFresnel;

	private Dictionary<Camera, CommandBuffer> m_Cameras;

	private static CameraEvent kCameraEvent;

	private static readonly float[,] offsets;

	private Camera m_ShadowmapCamera;

	private Transform m_ShadowmapCameraTransform;

	[HideInInspector]
	public Shader m_ShadowmapShader;

	[HideInInspector]
	public Shader m_BlurShadowmapShader;

	private Material m_BlurShadowmapMaterial;

	private RenderTexture m_Shadowmap;

	private RenderTexture m_BlurredShadowmap;

	private Texture2D m_ShadowmapDummy;

	private int m_ShadowmapRenderTime;

	private int m_BlurredShadowmapRenderTime;

	private FogLight m_FogLight;

	private RenderTexture[] temp;

	public bool m_RenderSource;

	public Vector3 m_Size;

	[Range(0f, 179f)]
	public float m_Angle;

	[MinValue(0f)]
	public float m_Intensity;

	public Color m_Color;

	[Header("Shadows")]
	public bool m_Shadows;

	public LayerMask m_ShadowCullingMask;

	public AreaLight.TextureSize m_ShadowmapRes;

	[MinValue(0f)]
	public float m_ReceiverSearchDistance;

	[MinValue(0f)]
	public float m_ReceiverDistanceScale;

	[MinValue(0f)]
	public float m_LightNearSize;

	[MinValue(0f)]
	public float m_LightFarSize;

	[Range(0f, 0.1f)]
	public float m_ShadowBias;

	private MeshRenderer m_SourceRenderer;

	private Mesh m_SourceMesh;

	[HideInInspector]
	public Mesh m_Quad;

	private Vector2 m_CurrentQuadSize;

	private Vector3 m_CurrentSize;

	private float m_CurrentAngle;

	private bool m_Initialized;

	private MaterialPropertyBlock m_props;

	private static Vector3[] vertices;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool InitDirect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpLUTs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Cleanup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CommandBuffer GetOrCreateCommandBuffer(Camera cam)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUpCommandBuffer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetKeyword(string keyword, bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseTemporary(ref RenderTexture rt)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color GetColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateShadowmap(int res)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RenderTexture GetBlurredShadowmap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateBlurredShadowmap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Blur(RenderTexture src, RenderTexture dst, int pass)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderQuad()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpShadowmapForSampling(CommandBuffer buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitMaterial(ref Material material, Shader shader)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitShadowmapDummy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitFogLight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool InsideShadowmapCameraRender()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector4 GetZParams()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateSourceMesh()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnWillRenderObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float GetNearToCenter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Matrix4x4 GetOffsetMatrix(float zOffset)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Matrix4x4 GetProjectionMatrix(bool linearZ = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector4 MultiplyPoint(Matrix4x4 m, Vector3 v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Matrix4x4 PerspectiveLinearZ(float fov, float aspect, float near, float far)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector4 GetPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Bounds GetFrustumBounds()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AreaLight()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AreaLight()
	{
		throw null;
	}

	public enum TextureSize
	{
		x512 = 512,
		x1024 = 1024,
		x2048 = 2048,
		x4096 = 4096
	}
}
