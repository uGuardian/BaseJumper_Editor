using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision FX")]
public class CameraFilterPack_NightVisionFX : MonoBehaviour
{
	public Shader SCShader;

	public CameraFilterPack_NightVisionFX.preset Preset;

	private CameraFilterPack_NightVisionFX.preset PresetMemo;

	private float TimeX;

	private Material SCMaterial;

	[Range(0f, 1f)]
	public float OnOff;

	[Range(0.2f, 2f)]
	public float Greenness;

	[Range(0f, 1f)]
	public float Vignette;

	[Range(0f, 1f)]
	public float Vignette_Alpha;

	[Range(-10f, 10f)]
	public float Distortion;

	[Range(0f, 1f)]
	public float Noise;

	[Range(-2f, 1f)]
	public float Intensity;

	[Range(0f, 2f)]
	public float Light;

	[Range(0f, 1f)]
	public float Light2;

	[Range(0f, 2f)]
	public float Line;

	[Range(-2f, 2f)]
	public float Color_R;

	[Range(-2f, 2f)]
	public float Color_G;

	[Range(-2f, 2f)]
	public float Color_B;

	[Range(0f, 1f)]
	public float _Binocular_Size;

	[Range(0f, 1f)]
	public float _Binocular_Smooth;

	[Range(0f, 1f)]
	public float _Binocular_Dist;

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
	public CameraFilterPack_NightVisionFX()
	{
		throw null;
	}

	public enum preset
	{
		Night_Vision_Personalized = -1,
		Night_Vision_FX,
		Night_Vision_Classic,
		Night_Vision_Full,
		Night_Vision_Dark,
		Night_Vision_Sharp,
		Night_Vision_BlueSky,
		Night_Vision_Low_Light,
		Night_Vision_Pinky,
		Night_Vision_RedBurn,
		Night_Vision_PurpleShadow
	}
}
