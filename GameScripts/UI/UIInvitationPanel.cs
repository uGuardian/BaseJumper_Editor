using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIInvitationPanel : UIPanel
	{
		[Header("Reference")]
		[Header("RightPanel")]
		[SerializeField]
		private UIInvitationRightMainPanel _invRightMainPanel;

		[Header("LeftPanel")]
		[SerializeField]
		private UIInvitationInfoPanel _invLeftInfoPanel;

		[Header("Center Panel")]
		[SerializeField]
		private UIStoryProgressPanel _invCenterStoryPanel;

		[SerializeField]
		private UIInvitationDropBookList _invCenterBookListPanel;

		public RectTransform gradeFilterFrameRect;

		[Header("controller")]
		[SerializeField]
		private List<GameObject> controllerGuideIcons;

		private StageClassInfo _currentStage;

		[HideInInspector]
		public UIStoryProgressIconSlot currentSelectedStorySlot;

		[HideInInspector]
		public int currentStoryidx;

		private InvitationApply_State _currentApplyState;

		private UIInvitationPhaseState _currentPhaseState;

		public UIInvitationRightMainPanel InvRightMainPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIInvitationInfoPanel InvLeftInfoPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIStoryProgressPanel InvCenterStoryPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIInvitationDropBookList InvCenterBookListPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public StageClassInfo CurrentStage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public InvitationApply_State CurrentApplyState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIInvitationPhaseState CurrentPhaseState
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
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelPdLeftPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelPdRightPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseExit(UIPhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPhaseState(UIInvitationPhaseState state, bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentStage(StageClassInfo stage)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetApplyState(UIStoryProgressIconSlot storySlot, int idx = -1)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPhaseNavigation(UIInvShowInfoState phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateDropBookInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectWaveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectEnemySlot(UnitDataModel unit)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySlotIdByDropBookInv(LorId id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<LorId> GetAppliedBooksId()
		{
			throw null;
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
		public UIStoryLine GetTheBlueReverberationPrimaryStage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIEnemyCharacterListPanel GetEnemyListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationPanel()
		{
			throw null;
		}
	}
}
