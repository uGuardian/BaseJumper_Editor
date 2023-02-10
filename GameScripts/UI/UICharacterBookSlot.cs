using System;
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(WorkshopSkinData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(DropBookXmlInfo useEffect)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnknown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetClickable(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataByLibrary(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeProperty(bool isequip = true)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPressColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartLighting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator Lighting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetAlpha(Graphic g, float a)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimSlotDefaultInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFeedBookAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterBookSlot()
		{
			throw null;
		}
	}
}
