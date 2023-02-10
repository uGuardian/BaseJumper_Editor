using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/ColorsAdjust/Photo Filters")]
public class CameraFilterPack_Colors_Adjust_PreFilters : MonoBehaviour
{
	private string ShaderName;

	public Shader SCShader;

	public CameraFilterPack_Colors_Adjust_PreFilters.filters filterchoice;

	[Range(0f, 1f)]
	public float FadeFX;

	private float TimeX;

	private Material SCMaterial;

	private float[] Matrix9;

	private Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeFilters()
	{
		throw null;
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
	public CameraFilterPack_Colors_Adjust_PreFilters()
	{
		throw null;
	}

	public enum filters
	{
		Normal,
		BlueLagoon,
		BlueMoon,
		RedWhite,
		NashVille,
		VintageYellow,
		GoldenPink,
		DarkPink,
		PopRocket,
		RedSoftLight,
		YellowSunSet,
		Walden,
		WhiteShine,
		Fluo,
		MarsSunRise,
		Amelie,
		BlueJeans,
		NightVision,
		BlueParadise,
		Blindness_Deuteranomaly,
		Blindness_Protanopia,
		Blindness_Protanomaly,
		Blindness_Deuteranopia,
		Blindness_Tritanomaly,
		Blindness_Achromatopsia,
		Blindness_Achromatomaly,
		Blindness_Tritanopia,
		BlackAndWhite_Blue,
		BlackAndWhite_Green,
		BlackAndWhite_Orange,
		BlackAndWhite_Red,
		BlackAndWhite_Yellow
	}
}
