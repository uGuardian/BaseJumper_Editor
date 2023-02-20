using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/Lut 2 Lut Extra")]
public class CameraFilterPack_Lut_2_Lut_Extra : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Vector4 ScreenResolution;

	private Material SCMaterial;

	public Texture2D LutTexture;

	public Texture2D LutTexture2;

	private Texture3D converted3DLut;

	private Texture3D converted3DLut2;

	[Range(0f, 1f)]
	public float FadeLut1;

	[Range(0f, 1f)]
	public float FadeLut2;

	[Range(0f, 1f)]
	public float Pos;

	[Range(0f, 1f)]
	public float Smooth;

	private string MemoPath;

	private string MemoPath2;

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
	public void SetIdentityLut()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ValidDimensions(Texture2D tex2d)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Texture3D Convert(Texture2D temp2DTex, Texture3D cv3D)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
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
	public CameraFilterPack_Lut_2_Lut_Extra()
	{
		throw null;
	}
}
