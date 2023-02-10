using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class TubeLight : MonoBehaviour
{
	public float m_Intensity;

	public Color m_Color;

	public float m_Range;

	public float m_Radius;

	public float m_Length;

	[HideInInspector]
	public Mesh m_Sphere;

	[HideInInspector]
	public Mesh m_Capsule;

	[HideInInspector]
	public Shader m_ProxyShader;

	private Material m_ProxyMaterial;

	public bool m_RenderSource;

	private Renderer m_SourceRenderer;

	private Transform m_SourceTransform;

	private Mesh m_SourceMesh;

	private float m_LastLength;

	public const int maxPlanes = 2;

	[HideInInspector]
	public TubeLightShadowPlane[] m_ShadowPlanes;

	private bool m_Initialized;

	private MaterialPropertyBlock m_props;

	private const float kMinRadius = 0.001f;

	private Dictionary<Camera, CommandBuffer> m_Cameras;

	private static CameraEvent kCameraEvent;

	private TubeLightShadowPlane.Params[] sppArr;

	private bool renderSource
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
	private void Cleanup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMeshesAndBounds()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color GetColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnWillRenderObject()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetUpCommandBuffer()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TubeLightShadowPlane.Params[] GetShadowPlaneParams(ref TubeLightShadowPlane.Params[] p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetShadowPlaneVectors(CommandBuffer buf)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool InsideShadowmapCameraRender()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TubeLight()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TubeLight()
	{
		throw null;
	}
}
