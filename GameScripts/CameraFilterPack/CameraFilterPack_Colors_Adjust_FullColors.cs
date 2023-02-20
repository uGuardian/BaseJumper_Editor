using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/ColorsAdjust/FullColors")]
public class CameraFilterPack_Colors_Adjust_FullColors : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	[Range(-200f, 200f)]
	public float Red_R;

	[Range(-200f, 200f)]
	public float Red_G;

	[Range(-200f, 200f)]
	public float Red_B;

	[Range(-200f, 200f)]
	public float Red_Constant;

	[Range(-200f, 200f)]
	public float Green_R;

	[Range(-200f, 200f)]
	public float Green_G;

	[Range(-200f, 200f)]
	public float Green_B;

	[Range(-200f, 200f)]
	public float Green_Constant;

	[Range(-200f, 200f)]
	public float Blue_R;

	[Range(-200f, 200f)]
	public float Blue_G;

	[Range(-200f, 200f)]
	public float Blue_B;

	[Range(-200f, 200f)]
	public float Blue_Constant;

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
	public CameraFilterPack_Colors_Adjust_FullColors()
	{
		throw null;
	}
}
