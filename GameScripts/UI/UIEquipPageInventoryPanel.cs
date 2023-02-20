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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
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
		public void ChangeEquipBook()
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
