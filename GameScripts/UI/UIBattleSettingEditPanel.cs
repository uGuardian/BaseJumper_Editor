using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleSettingEditPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Canvas canvas;

		[SerializeField]
		private UISettingEquipPageInvenPanel _equipPagePanel;

		[SerializeField]
		private UISettingCardInvenPanel _battleCardPanel;

		[SerializeField]
		private Button button_EquipPage;

		[SerializeField]
		private Button button_BattleCard;

		[SerializeField]
		private Image img_equippageFrame;

		[SerializeField]
		private Image img_battlecardFrame;

		[SerializeField]
		private RectTransform rect_LeftBg;

		[SerializeField]
		private Image img_BlockBackGroundBg;

		private UIBattleSettingEditTap _currentstate;

		public bool isOpen;

		public UISettingEquipPageInvenPanel EquipPagePanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UISettingCardInvenPanel BattleCardPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIBattleSettingEditTap CurrentState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Open(UIBattleSettingEditTap state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close(bool force = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool on, bool forceoff = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetActiveState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBUttonState(UIBattleSettingEditTap state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEquipPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBattleCard()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingEditPanel()
		{
			throw null;
		}
	}
}
