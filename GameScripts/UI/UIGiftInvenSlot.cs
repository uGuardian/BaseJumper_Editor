using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIGiftInvenSlot : MonoBehaviour
	{
		[SerializeField]
		private GraphicBundle graphics;

		[SerializeField]
		private Image img_Gift;

		[SerializeField]
		private TextMeshProUGUI txt_Part;

		[SerializeField]
		private TextMeshProUGUI txt_Name;

		[SerializeField]
		private TextMeshProUGUI txt_desc;

		[SerializeField]
		private GameObject conditionTextGameObject;

		[SerializeField]
		private TextMeshProUGUI txt_getcondition;

		public UICustomSelectable selectable;

		[HideInInspector]
		public GiftModel giftData;

		private UIGiftInventory panel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(GiftModel gift, UIGiftInventory inven)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty(UIGiftInventory inven)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterPointer(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitPointer(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSlot(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightedColor(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGiftInvenSlot()
		{
			throw null;
		}
	}
}
