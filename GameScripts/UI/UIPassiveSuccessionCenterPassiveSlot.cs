using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionCenterPassiveSlot : MonoBehaviour
	{
		[Header("Reference")]
		public UIPassiveSuccessionCenterEquipBookSlot panel;

		public RectTransform rect;

		public RectTransform rect_vibeRoot;

		public UICustomSelectable selectable;

		public Animator anim;

		public CanvasGroup cg_UsingOb;

		public RectTransform rect_UsingOb;

		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private Image img_UsingFrameGlow;

		[SerializeField]
		private TextMeshProUGUI txt_Name;

		[SerializeField]
		private TextMeshProUGUI txt_Desc;

		[SerializeField]
		private Image img_highlighted;

		[Header("UsingAlarm")]
		[SerializeField]
		private GameObject ob_UsingAlarm;

		[Header("LevelLock")]
		[SerializeField]
		private GameObject ob_LevelLock;

		[SerializeField]
		private TextMeshProUGUI txt_needLevel;

		[Header("ReleaseHighlighted")]
		[SerializeField]
		private GameObject ob_ReleaseAlarm;

		[SerializeField]
		private Image img_ReleaseHighlightedFrame;

		[SerializeField]
		private Image img_ReleaseBg;

		[SerializeField]
		private TextMeshProUGUI txt_Cost;

		[SerializeField]
		private List<Graphic> graphics_Rarity;

		private PassiveModel passivemodel;

		private bool isLock;

		private bool isUsing;

		private const float minSlotHeight = 30f;

		private const float originframeoffset = 29f;

		private const float textoffset = 12f;

		private bool equiporiginbook;

		private GivePassiveState currentPassiveState;

		public float vibeRunningTime;

		private Coroutine vibeRoutine;

		[Range(0f, 20f)]
		public float startvibepower;

		public PassiveModel Passivemodel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public BookModel CurrentBookModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(PassiveModel passive)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataOriginBook(PassiveModel passive)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSize(float height)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByRarity(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByUsing(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool selected)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIPassiveSuccessionPopup GetPassivePoupPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffNormalSlotInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartUsingAnimation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopVibe()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartVibe()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator SlotVibeProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterPassiveSlot()
		{
			throw null;
		}
	}
}
