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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<StageClassInfo> stages)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSlots()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateUpButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateDownButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectStage(UIInvitationRightCustomSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickInApplyButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickInScrollUpButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickInScrollDownButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationRightCustomPanel()
		{
			throw null;
		}
	}
}
