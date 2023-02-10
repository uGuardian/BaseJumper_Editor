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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNeedSlot(LorId id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActiveOnTutoHighlightFrame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c, bool hasbook)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorSelectedSlot(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySlot(DropBookXmlInfo book, bool isapply)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySlotid(LorId id, bool isapply)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyNeedSlotid(LorId id, bool isapply)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyNeedSlot(DropBookXmlInfo book, bool isapply)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFullAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNextReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAnimationEvent(int eventId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOriginColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInvitationSlotSelected(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselectedByOther()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationBookSlot()
		{
			throw null;
		}
	}
}
