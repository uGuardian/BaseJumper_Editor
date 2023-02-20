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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotDeactive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickXBox()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookCardEquipInfoSlot()
		{
			throw null;
		}
	}
}
