using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIEquipPageInventoryLeftPanel : MonoBehaviour
	{
		[Header("EquipPage List")]
		[SerializeField]
		private UIInvenLeftEquipPageList equipPageList;

		[Header("Tap")]
		[SerializeField]
		private Button button_BookMark;

		[SerializeField]
		private Button button_EquipedBook;

		[SerializeField]
		private GameObject[] obs_bookmark;

		[SerializeField]
		private GameObject[] obs_equipedbook;

		[SerializeField]
		private TextMeshProUGUI txt_bookmark;

		[SerializeField]
		private TextMeshProUGUI txt_equipedbook;

		public UICustomSelectablePanel selectablePanel;

		private UIBookInvenLeftPanelShowState currentShowState;

		public UIInvenLeftEquipPageList EquipPageList
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
		public void SetButtonHighlighted(Button b, bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel GetEquipPageInventoryPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryLeftPanel()
		{
			throw null;
		}
	}
}
