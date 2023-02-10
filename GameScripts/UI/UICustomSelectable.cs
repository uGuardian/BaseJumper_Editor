using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent(typeof(EventTrigger))]
	[RequireComponent(typeof(UISelectableIconController))]
	public class UICustomSelectable : Selectable
	{
		public const string TAG_BATTLE_LT_MENU = "battleLtMenu";

		public const string TAG_BATTLE_HAND = "battleHand";

		public string selectableTag;

		[Header("HighlightFrame")]
		[SerializeField]
		private GameObject HighlightFrame;

		[Header("Node")]
		public UICustomSelectable parentSelectable;

		public UICustomSelectable ChildSelectable;

		[Header("Events")]
		public UnityEventBasedata SubmitEvent;

		[SerializeField]
		public UnityEventBasedata CancelEvent;

		[SerializeField]
		public UnityEventBasedata SelectEvent;

		[SerializeField]
		public UnityEventBasedata DeselectEvent;

		[SerializeField]
		public UnityEventBasedata XEvent;

		[SerializeField]
		public UnityEventBasedata YEvent;

		[Header("Auto Event Trigger Add")]
		[SerializeField]
		private bool addCancel;

		[SerializeField]
		private bool addSubmit;

		[SerializeField]
		private bool addClick;

		[Header("Auto Events")]
		[SerializeField]
		private bool SubmitToChildEvent;

		[SerializeField]
		private bool CanelToParentEvent;

		private EventTrigger trigger;

		[HideInInspector]
		public UISelectableIconController iconController;

		private bool isselected;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSelect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeselect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectForcely()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnXEvent(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnYEvent(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightFrameActive(bool isTrue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Selectable FindSelectableOnUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Selectable FindSelectableOnDown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Selectable FindSelectableOnLeft()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Selectable FindSelectableOnRight()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectablePanel FindSelectablePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNavigationObject(NavigationDir dir, UICustomSelectable selectableObject)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable()
		{
			throw null;
		}
	}
}
