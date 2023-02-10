using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundEffectPanel : MonoBehaviour, IDragHandler, IEventSystemHandler
{
	public StoryEditorRightPanel rightPanel;

	public SoundEffectSelector toggleRef;

	public List<SoundEffectSelector> selectedEffects;

	private List<SoundEffectSelector> allEffects;

	public AudioSource ac;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDlgEffect(DlgEffect effect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleEffectSound(SoundEffectSelector s)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickConfirm()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickActive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickClose()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrag(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoundEffectPanel()
	{
		throw null;
	}
}
