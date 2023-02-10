using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UILibrarianEquipDeckPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private Image img_LineFrame;

		[SerializeField]
		private GraphicBundle Frames;

		[SerializeField]
		private TextMeshProUGUI txt_unitName;

		[SerializeField]
		private Image img_BookIconGlow;

		[SerializeField]
		private Image img_BookIcon;

		[SerializeField]
		private TextMeshProUGUI txt_BookName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_bookname;

		[Header("Deck")]
		[SerializeField]
		private UIEquipDeckCardList _equipDeckPanel;

		public UIDeckList DeckListPanel;

		[Header("Controller")]
		public UICustomSelectablePanel SelectablePanel;

		private UnitDataModel _unitdata;

		[Header("Deck Buttons")]
		[SerializeField]
		private UICustomGraphicObject button_SaveDeckButton;

		[SerializeField]
		private UICustomGraphicObject button_OpenDeckListButton;

		[SerializeField]
		private UICustomGraphicObject button_EmptyDeckButton;

		[SerializeField]
		private UICustomGraphicObject button_CloseDeckButton;

		public UIEquipDeckCardList EquipDeckPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool idDeckListActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UnitDataModel Unitdata
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckBluePrimary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsLockBattleBluePrimary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetRarityColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisablePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultColorPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSaveDeckButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable GetOpenDeckListSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickOpenDeckListButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDeckButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickClearDeckButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsMultiDeck()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCloseDeckListButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianEquipDeckPanel()
		{
			throw null;
		}
	}
}
