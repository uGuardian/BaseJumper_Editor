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
	public class UIPassiveSuccessionSlot : MonoBehaviour
	{
		[SerializeField]
		private UIPassiveSuccessionList panel;

		public Animator anim;

		public CanvasGroup dataRootCg;

		public RectTransform rect;

		public UICustomSelectable selectable;

		[Header("Frames")]
		[SerializeField]
		private Image Frame;

		[SerializeField]
		private RectTransform rect_dataRoot;

		[SerializeField]
		private GameObject dataRoot;

		[SerializeField]
		private Image Img_equipIconImg;

		[SerializeField]
		private Image Img_equipIconGlowImg;

		[SerializeField]
		private TextMeshProUGUI txt_euipName;

		[SerializeField]
		private TextMeshProUGUI txt_euipDesc;

		[SerializeField]
		public Image img_highligted;

		[SerializeField]
		private List<Graphic> rarityGraphics;

		[SerializeField]
		private List<Graphic> normalGraphics;

		[SerializeField]
		private GameObject ob_LockRoot;

		[SerializeField]
		private GameObject addedDataRoot;

		[SerializeField]
		private TextMeshProUGUI txt_CostText;

		protected Color originalColor;

		[Header("Release")]
		[SerializeField]
		private GameObject ob_releaseRoot;

		[SerializeField]
		private Image img_Releasebg;

		[SerializeField]
		private Image img_ReleaseHighlighted;

		private BookPassiveInfo _currentPassiveInfo;

		public PassiveModel passivemodel;

		private UIPassiveToggleState currentToggleState;

		public bool isLock;

		public bool isEmpty;

		public bool isBlock;

		public bool isAnimationSlot;

		public bool OffSound;

		private const float minSlotHeight = 28f;

		private const float originframeoffset = 27f;

		private const float textoffset = 11f;

		private PassiveModel nextpassive;

		public float vibeRunningTime;

		private Coroutine vibeRoutine;

		[Range(0f, 20f)]
		public float startvibepower;

		public BookPassiveInfo CurrentPassiveInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetDataModel(PassiveModel passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLockPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool selected)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByRarity(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByDefault(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSize(float height)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
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
		public void SetOffNormalSlotInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightedCurrentSlotInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffAnimationSlotInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimationSlot(PassiveModel prevPassive, PassiveModel currentPassive, bool release = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNextPassiveInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealSoundInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionPopup GetRootPanel()
		{
			throw null;
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
		public UIPassiveSuccessionSlot()
		{
			throw null;
		}
	}
}
