using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_DemoGUI : MonoBehaviour
{
	public GameObject[] Prefabs;

	public float[] ReactivationTimes;

	public Light Sun;

	public ReflectionProbe ReflectionProbe;

	public Light[] NightLights;

	public Texture HUETexture;

	public bool UseMobileVersion;

	public RFX4_DistortionAndBloom RFX4_DistortionAndBloom;

	private int currentNomber;

	private GameObject currentInstance;

	public GUIStyle guiStyleHeader;

	public GUIStyle guiStyleHeaderMobile;

	private float dpiScale;

	private bool isDay;

	private float colorHUE;

	private float startSunIntensity;

	private Quaternion startSunRotation;

	private Color startAmbientLight;

	private float startAmbientIntencity;

	private float startReflectionIntencity;

	private LightShadows startLightShadows;

	private bool isButtonPressed;

	private bool isUsedMobileBloom;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeCurrent(int delta)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveClones()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Reactivate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_DemoGUI()
	{
		throw null;
	}
}
