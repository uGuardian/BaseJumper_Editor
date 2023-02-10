using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PostProcessing;

public class CamFilterController : SingletonBehavior<CamFilterController>
{
	public CameraFilterPack_AAA_Blood_Hit bloodFilter;

	public CameraFilterPack_Blur_Bloom bloomFilter;

	public CameraFilterPack_Blur_Noise noiseFilter;

	public CameraFilterPack_TV_ARCADE tvFilter;

	public CameraFilterPack_TV_Old_Movie_2 oldtvFilter;

	public CameraFilterPack_Noise_TV_3 distortfilter;

	public CameraFilterPack_FX_EarthQuake earthQuakefilter;

	public CameraFilterPack_Atmosphere_Rain rainFilter;

	public CameraFilterPack_TV_Horror horrorFilter;

	public CameraFilterPack_3D_Myst mystFilter;

	public CameraFilterPack_Blur_Blurry blurryFilter;

	public CameraFilterPack_Color_YUV colorYUVFilter;

	public CameraFilterPack_TV_WideScreenHorizontal horizontalBlackFilter;

	public CameraFilterPack_3D_Shield shieldFilter;

	public CameraFilterPack_Gradients_FireGradient fireFilter;

	public CameraFilterPack_Colors_Brightness BrightFilter;

	public PostProcessingBehaviour postProcessor;

	public GameObject paperParticleObj;

	public GameObject pillaroflightParticleObj;

	public GameObject fireEffect;

	public GameObject LightPoleEffect;

	public Camera mainCam;

	private Vector3 _originPos;

	private ParticleSystem _particle;

	[HideInInspector]
	public float FadeCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CamFilterController()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilter(string filterID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ShakeCamRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BloomRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator PillarOfLightRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BloomAndPillarOfLightRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BloodFilterRoutine(int dir = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator DistortFilterRoutine(int dir = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EmergencyRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibrationFilterRoutine(int dir = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeIn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOut()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlackFadeoutFlashing()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlackFadein()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlackFadeinLong()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibrationWeakFilterRoutine(int dir = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}
}
