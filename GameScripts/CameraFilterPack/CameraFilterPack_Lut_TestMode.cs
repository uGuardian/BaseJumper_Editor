using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/TestMode")]
public class CameraFilterPack_Lut_TestMode : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	public Texture2D LutTexture;

	private Texture3D converted3DLut;

	[Range(0f, 1f)]
	public float Blend;

	[Range(0f, 3f)]
	public float OriginalIntensity;

	[Range(-1f, 1f)]
	public float ResultIntensity;

	[Range(-1f, 1f)]
	public float FinalIntensity;

	[Range(0f, 1f)]
	public float TestMode;

	private string MemoPath;

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
	public void SetIdentityLut()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ValidDimensions(Texture2D tex2d)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Convert(Texture2D temp2DTex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
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
	public CameraFilterPack_Lut_TestMode()
	{
		throw null;
	}
}
