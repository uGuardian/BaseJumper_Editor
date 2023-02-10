using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UISettingEquipPageInvenPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[Header("Left")]
		[SerializeField]
		private UISettingEquipPageInvenLeftPanel _equipLeftPanel;

		[Header("CenterPanel")]
		[SerializeField]
		private UISettingEquipPageScrollList _equipPageScrollList;

		[Header("Preview Panel")]
		[SerializeField]
		private UIEquipPagePreviewPanel _equipPagePreviewPanel;

		[Header("Insepector Setting")]
		[SerializeField]
		private Vector3 targetPosForPreviewPanel;

		public float startspeed;

		public float endspeed;

		private UIOriginEquipPageSlot _currentSelectedSlot;

		[HideInInspector]
		public UIOriginEquipPageSlot currentOverSlot;

		private float revealSpeed;

		private float revealCount;

		private float startalpha;

		private float Endalpha;

		private bool isRunningRevealPreviewPanel;

		[HideInInspector]
		public bool isSaveCheck;

		private bool isPreviewVisible;

		public UISettingEquipPageInvenLeftPanel EquipLeftPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UISettingEquipPageScrollList EquipPageScrollList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIOriginEquipPageSlot CurrentSelectedSlot
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
		public void SetActivePanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateRightPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateLeftPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateCenterPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePreviewPanel(UIOriginEquipPageSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeEquipBook(UnitDataModel unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchPreviewVisible(UIOriginEquipPageSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowPreviewPanel(UIOriginEquipPageSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HidePreviewPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevealPreviewPanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealPreviewPanelProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopRevealCoroutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSlot(UIOriginEquipPageSlot leftclickSlot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSelectedSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSelectedSlotNotHidePreview()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingPanel GetBattleSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISettingEquipPageInvenPanel()
		{
			throw null;
		}
	}
}
