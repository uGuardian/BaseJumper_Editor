using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIBookCardEquipInfoSlot : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private Image iconGlow;

		[SerializeField]
		private TextMeshProUGUI bookNameText;

		[SerializeField]
		private TextMeshProUGUI countText;

		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private Image img_ButtonFrame;

		[SerializeField]
		private Image img_x;

		[SerializeField]
		private Button button_Xbox;

		public UICustomSelectable selectable;

		private UICardEquipInfoPanel Root;

		private BookModel book;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotActive(BookModel _book, int count, UICardEquipInfoPanel root)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotDeactive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickXBox()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookCardEquipInfoSlot()
		{
			throw null;
		}
	}
}
