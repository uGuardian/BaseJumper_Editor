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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateRightPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateLeftPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateCenterPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePreviewPanel(UIOriginEquipPageSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeEquipBook(UnitDataModel unit)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchPreviewVisible(UIOriginEquipPageSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowPreviewPanel(UIOriginEquipPageSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HidePreviewPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevealPreviewPanel(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealPreviewPanelProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopRevealCoroutine()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSlot(UIOriginEquipPageSlot leftclickSlot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSelectedSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSelectedSlotNotHidePreview()
		{
			
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
