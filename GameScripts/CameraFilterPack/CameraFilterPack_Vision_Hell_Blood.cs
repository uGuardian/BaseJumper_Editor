using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Hell_Blood")]
public class CameraFilterPack_Vision_Hell_Blood : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float Hole_Size;

	[Range(0f, 0.5f)]
	public float Hole_Smooth;

	[Range(-2f, 2f)]
	public float Hole_Speed;

	[Range(-10f, 10f)]
	public float Intensity;

	public Color ColorBlood;

	[Range(-1f, 1f)]
	public float BloodAlternative1;

	[Range(-1f, 1f)]
	public float BloodAlternative2;

	[Range(-1f, 1f)]
	public float BloodAlternative3;

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
	public CameraFilterPack_Vision_Hell_Blood()
	{
		throw null;
	}
}
