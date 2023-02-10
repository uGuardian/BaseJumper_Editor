using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIBookPanel : UIPanel
	{
		[Header("Center Book List Panel")]
		public UIInvenFeedBookList invenFeedBookList;

		[Header("Left FeedBookPanel")]
		public UIShowUsingBookInfoPanel DropBookInfoPanel;

		[Header("Right BookInfoPanel")]
		public UIFloorFeedBookPanel floorFeedbookPanel;

		[Header("Release Button")]
		[SerializeField]
		private UICustomGraphicObject button_AllReleaseButton;

		[Header("Total")]
		[HideInInspector]
		public UIBookSlot CurrentMouseOverSlot;

		[Header("Controller")]
		public List<GameObject> controllerGuideIcons;

		private List<LorId> _currentAddedBookIdList;

		public List<LorId> CurrentAddedBookIdList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
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
		public override void OnClose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateCenterPanel(bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpdateRightPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpdateLeftPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ButtonDownFeedBook()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FeedBookTargetSephirah(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckApplyButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AddFeedingBook_Floor(LorId bookId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SubFeedingBook_Floor(LorId bookId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractReleaseButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickAllReleaseButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAddedBookClear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLeftMenuEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isController)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookPanel()
		{
			throw null;
		}
	}
}
