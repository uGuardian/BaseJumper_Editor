using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIInvitationRightCustomPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIInvitationRightMainPanel rootpanel;

		[SerializeField]
		private Transform transform_slotRoots;

		[SerializeField]
		private CustomButton button_apply;

		[SerializeField]
		private Button button_scrollup;

		[SerializeField]
		private Button button_scrolldown;

		private List<UIInvitationRightCustomSlot> customSlotList;

		public int currentstagespageidx;

		private List<StageClassInfo> stageList;

		private StageClassInfo _currentSelectStageInfo;

		public StageClassInfo CurrentSelectStageInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(UIInvitationRightMainPanel root)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<StageClassInfo> stages)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSlots()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateUpButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateDownButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectStage(UIInvitationRightCustomSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickInApplyButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickInScrollUpButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickInScrollDownButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationRightCustomPanel()
		{
			throw null;
		}
	}
}
