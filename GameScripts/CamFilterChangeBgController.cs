using System;
using System.Collections;
using System.Runtime.CompilerServices;
using StoryScene;
using UnityEngine;

public class CamFilterChangeBgController : MonoBehaviour
{
	[Header("Change Bg")]
	[SerializeField]
	private CameraFilterPack_TV_BrokenGlass brokenFilter;

	[SerializeField]
	private CameraFilterPack_Color_BrightContrastSaturation brightnessFilter;

	[SerializeField]
	private CameraFilterPack_Broken_Screen brokenscreenFilter;

	[SerializeField]
	private AnimationCurve brokenTimerCurve;

	[HideInInspector]
	public bool isRunningBrokenScreenChange;

	[HideInInspector]
	public bool isRunningFadeScreenChange;

	[SerializeField]
	private AnimationCurve fadescreenTimerCurve;

	[SerializeField]
	private StoryManager storymanager;

	[Range(0f, 10f)]
	[SerializeField]
	private float brokenspeed;

	[Range(0f, 2f)]
	[SerializeField]
	private float brokenwaittime;

	[Range(0f, 3f)]
	[SerializeField]
	private float fadeWaitTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartBrokenChangeAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChangeAnimProcessDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BrokenScreen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartFadeChangeAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutScreen()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CamFilterChangeBgController()
	{
		throw null;
	}
}
