using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIEquipPageInventoryPanel : UIPanel
	{
		[Header("LeftPanel")]
		[SerializeField]
		private UIEquipPageInventoryLeftPanel _equipLeftPanel;

		[SerializeField]
		private UIEquipPageScrollList _equipPageScrollListPanel;

		[Header("RightPanel")]
		[SerializeField]
		private UILibrarianInfoInCardPhase _librarianInfo;

		[Header("Preview Panel")]
		[SerializeField]
		private UIEquipPagePreviewPanel _equipPagePreviewPanel;

		[SerializeField]
		public UIOriginEquipPageSlot currentOverSlot;

		private UIOriginEquipPageSlot _currentSelectedSlot;

		[SerializeField]
		private Vector3 targetPosForPreviewPanel;

		public float startspeed;

		public float endspeed;

		private float revealSpeed;

		private float revealCount;

		private float startalpha;

		private float Endalpha;

		private bool isRunningRevealPreviewPanel;

		[HideInInspector]
		public bool isSaveCheck;

		private bool isPreviewVisible;

		public UIEquipPageInventoryLeftPanel EquipLeftPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIEquipPageScrollList EquipPageScrollListPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private UILibrarianInfoInCardPhase LibrarianInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIEquipPagePreviewPanel EquipPagePreviewPanel
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
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
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
		public void ChangeEquipBook()
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
		private UILibrarianCharacterListPanel GetCharacterListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageInventoryPanel()
		{
			throw null;
		}
	}
}
