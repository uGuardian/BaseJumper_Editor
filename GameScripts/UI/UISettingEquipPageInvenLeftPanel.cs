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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInitData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEquipPageList(bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBookMark()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEquipedBook()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTapButtons(UIBookInvenLeftPanelShowState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonHighlighted(Selectable b, bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenPanel GetEquipInvenPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenLeftPanel()
		{
			throw null;
		}
	}
}
