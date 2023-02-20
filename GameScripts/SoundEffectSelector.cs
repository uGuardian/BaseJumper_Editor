using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class SoundEffectSelector : MonoBehaviour
{
	public SoundEffectPanel soundEffectPanel;

	public Toggle toggle;

	public AudioClip ac;

	public Text t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggle()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoundEffectSelector()
	{
		throw null;
	}
}
