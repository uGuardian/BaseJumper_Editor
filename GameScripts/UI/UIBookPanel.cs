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
		public override void OnClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateCenterPanel(bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpdateRightPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpdateLeftPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ButtonDownFeedBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FeedBookTargetSephirah(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckApplyButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AddFeedingBook_Floor(LorId bookId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SubFeedingBook_Floor(LorId bookId)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractReleaseButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickAllReleaseButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAddedBookClear()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLeftMenuEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isController)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookPanel()
		{
			throw null;
		}
	}
}
