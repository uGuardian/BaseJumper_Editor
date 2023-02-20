using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UISettingEquipPageInvenLeftPanel : MonoBehaviour
	{
		[Header("EquipPage List")]
		[SerializeField]
		private UISettingEquipPageLeftList equipPageList;

		[Header("Tap")]
		[SerializeField]
		private Selectable button_BookMark;

		[SerializeField]
		private Selectable button_EquipedBook;

		[SerializeField]
		private GameObject[] ob_bookmarkframes;

		[SerializeField]
		private GameObject[] ob_euqipedbookframes;

		[Header("Xbox Control")]
		public UICustomSelectablePanel selectablePanel;

		private UIBookInvenLeftPanelShowState currentShowState;

		public UISettingEquipPageLeftList EquipPageList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIBookInvenLeftPanelShowState CurrentShowState
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
		public void SetInitData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEquipPageList(bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBookMark()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEquipedBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTapButtons(UIBookInvenLeftPanelShowState state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonHighlighted(Selectable b, bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenPanel GetEquipInvenPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenLeftPanel()
		{
			throw null;
		}
	}
}
