﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	[RequireComponent(typeof(AudioSource))]
	public class UIButtonSound : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		private AudioSource audio_source;

		public UIButtonSoundType ButtonType;

		[Header("Default Type Setter")]
		public UISoundType ClickType;

		public UISoundType EnterType;

		public UISoundType ExitType;

		[Header("CheckPublic")]
		public AudioClip ClickSound;

		public AudioClip OverSound;

		public AudioClip ExitSound;

		public bool isdisabled;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySound(AudioClip clip)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIButtonSound()
		{
			throw null;
		}
	}
}
