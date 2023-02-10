﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Workshop;

namespace UI
{
	public class UICharacterBookSlot : MonoBehaviour
	{
		[SerializeField]
		private UIUpperTapButtonRootPanel buttonroot;

		[SerializeField]
		private Image Frame;

		[SerializeField]
		private Image Frame_Inner;

		[SerializeField]
		private Image Frame_InnerGlow;

		[SerializeField]
		private Image Frame_Outline;

		[SerializeField]
		private Image Icon;

		[SerializeField]
		private Image IconGlow;

		[SerializeField]
		private TextMeshProUGUI BookName;

		[SerializeField]
		private Image dupGlow;

		private List<Graphic> _targetGraphics;

		private List<Graphic> _defaultGraphics;

		private bool _uiinit;

		[Header("Animation Only")]
		[SerializeField]
		private Animator anim_animationCurrentBookSlot;

		[SerializeField]
		private TextMeshProMaterialSetter setter_name;

		private bool _clickable;

		private bool _selected;

		private BookModel _bookModel;

		public BookModel BookModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(WorkshopSkinData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(DropBookXmlInfo useEffect)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnknown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetClickable(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataByLibrary(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeProperty(bool isequip = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPressColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartLighting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator Lighting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetAlpha(Graphic g, float a)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimSlotDefaultInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFeedBookAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterBookSlot()
		{
			throw null;
		}
	}
}
