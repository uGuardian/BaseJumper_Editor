using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionBookSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIPassiveSuccessionBookListPanel panel;

		public RectTransform rect_pivot;

		public RectTransform rect;

		public Animator anim;

		public CanvasGroup cg;

		public UICustomSelectable selectable;

		[Header("BookFrames")]
		[SerializeField]
		private UIPassiveSuccessionBookSlot.SlotImageSet equipSet;

		[SerializeField]
		private Image img_Icon;

		[SerializeField]
		public Image img_IconGlow;

		[SerializeField]
		private Image HighlightedFill;

		[SerializeField]
		private TextMeshProUGUI txt_bookname;

		[Header("BookLevel")]
		[SerializeField]
		private GameObject levelRootob;

		[SerializeField]
		private Image img_levelFrame;

		[SerializeField]
		private TextMeshProUGUI txt_booklevel;

		[Header("EquipedFrame")]
		[SerializeField]
		private GameObject ob_equiped;

		[SerializeField]
		private GameObject ob_otherequiped;

		[SerializeField]
		private GameObject ob_UnEquipedPanel;

		[Header("Block Frame")]
		[SerializeField]
		private GameObject ob_blockFrame;

		[SerializeField]
		private Image img_SepIcon;

		private BookModel currentbookmodel;

		private bool isEquiped;

		private bool isOtherEquiped;

		private bool isDisabled;

		private const float ScaleFactor = 1.1f;

		public float vibeRunningTime;

		private Coroutine vibeRoutine;

		[Range(0f, 20f)]
		public float startvibepower;

		public BookModel CurrentBookModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptySlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquiped()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquipedOtherBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledByTheBluePrimary()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGlowColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
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
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffNormalSlotInAnim()
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
		public UIPassiveSuccessionBookSlot()
		{
			throw null;
		}

		[Serializable]
		public class SlotImageSet
		{
			public GameObject root;

			public Image Frame;

			public Image FrameGlow;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SlotImageSet()
			{
				throw null;
			}
		}
	}
}
