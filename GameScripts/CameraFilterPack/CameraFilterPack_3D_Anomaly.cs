using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Anomaly")]
public class CameraFilterPack_3D_Anomaly : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 100f)]
	public float _FixDistance;

	[Range(-0.5f, 0.99f)]
	public float Anomaly_Near;

	[Range(0f, 1f)]
	public float Anomaly_Far;

	[Range(0f, 2f)]
	public float Intensity;

	[Range(0f, 1f)]
	public float AnomalyWithoutObject;

	[Range(0.1f, 1f)]
	public float Anomaly_Distortion;

	[Range(4f, 64f)]
	public float Anomaly_Distortion_Size;

	[Range(-4f, 8f)]
	public float Anomaly_Intensity;

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
	public CameraFilterPack_3D_Anomaly()
	{
		throw null;
	}
}
