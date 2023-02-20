using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Blood_Hit")]
public class CameraFilterPack_AAA_Blood_Hit : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0f, 1f)]
	public float Hit_Left;

	[Range(0f, 1f)]
	public float Hit_Up;

	[Range(0f, 1f)]
	public float Hit_Right;

	[Range(0f, 1f)]
	public float Hit_Down;

	[Range(0f, 1f)]
	public float Blood_Hit_Left;

	[Range(0f, 1f)]
	public float Blood_Hit_Up;

	[Range(0f, 1f)]
	public float Blood_Hit_Right;

	[Range(0f, 1f)]
	public float Blood_Hit_Down;

	[Range(0f, 1f)]
	public float Hit_Full;

	[Range(0f, 1f)]
	public float Blood_Hit_Full_1;

	[Range(0f, 1f)]
	public float Blood_Hit_Full_2;

	[Range(0f, 1f)]
	public float Blood_Hit_Full_3;

	[Range(0f, 1f)]
	public float LightReflect;

	private Material SCMaterial;

	private Texture2D Texture2;

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
	public CameraFilterPack_AAA_Blood_Hit()
	{
		throw null;
	}
}
