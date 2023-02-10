using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Ghost")]
public class CameraFilterPack_3D_Ghost : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	public bool _Visualize;

	private Material SCMaterial;

	[Range(0f, 100f)]
	public float _FixDistance;

	[Range(-0.5f, 0.99f)]
	public float Ghost_Near;

	[Range(0f, 1f)]
	public float Ghost_Far;

	[Range(0f, 2f)]
	public float Intensity;

	[Range(0f, 1f)]
	public float GhostWithoutObject;

	[Range(-1f, 1f)]
	public float GhostPosX;

	[Range(-1f, 1f)]
	public float GhostPosY;

	[Range(0.1f, 8f)]
	public float GhostFade2;

	[Range(-1f, 1f)]
	public float GhostFade;

	[Range(0.5f, 1.5f)]
	public float GhostSize;

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
	public CameraFilterPack_3D_Ghost()
	{
		throw null;
	}
}
