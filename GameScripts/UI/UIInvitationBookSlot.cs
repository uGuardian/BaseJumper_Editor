using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIInvitationBookSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIInvitationRightMainPanel rootPanel;

		public UICustomSelectable selectable;

		[Header("Frames")]
		public Image HighlightedFill;

		public Image Frame;

		public Image FrameGlow;

		public Image Icon;

		public Image IconGlow;

		public Image blackFill;

		public TextMeshProUGUI BookName;

		public UIInvitationBookSlot Prev;

		public UIInvitationBookSlot Next;

		public CanvasGroup tooltip_X;

		[Header("Tutorial Highlight")]
		[SerializeField]
		private GameObject ob_tutorialhighlight;

		private bool _selected;

		private LorId needbookid;

		public bool isSelected;

		private DropBookXmlInfo _appliedBook;

		private LorId _appliedbookid;

		public Color originalColor;

		private bool isDisabled;

		[HideInInspector]
		public InvitationSlot_Type currentSlotType;

		private Animator _animCtrl
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public LorId NeedBookId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public DropBookXmlInfo AppliedBook
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public LorId Appliedbookid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptySlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNeedSlot(LorId id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActiveOnTutoHighlightFrame()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c, bool hasbook)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorSelectedSlot(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySlot(DropBookXmlInfo book, bool isapply)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySlotid(LorId id, bool isapply)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyNeedSlotid(LorId id, bool isapply)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyNeedSlot(DropBookXmlInfo book, bool isapply)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFullAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNextReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAnimationEvent(int eventId)
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
		public void OnPointerClick(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOriginColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInvitationSlotSelected(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselectedByOther()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationBookSlot()
		{
			throw null;
		}
	}
}
