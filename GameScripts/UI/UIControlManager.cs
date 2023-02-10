using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIControlManager : MonoBehaviour
	{
		private static UIControlManager _instance;

		public static bool isControllerInput;

		private const float inputTerm = 0.5f;

		private UICustomSelectablePanel currentSelectedSelectablePanel;

		public UICustomSelectable CurrentSelectedSelectable;

		private bool isMenuActive;

		private float inputCount;

		private Coroutine _setSelectableCoroutine;

		public PanelPosition CurrentPanelPosition;

		public static UIControlManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentSelectedSelectable(UICustomSelectable selectedSelectable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeUIPhase(UIPhase prev, UIPhase current)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRBEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLBEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReInit(bool success)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLeftMenuEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRightMenuEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SelectSelectableForcely(UICustomSelectable selectable, bool immediate = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator SetEventSystemCurrentSelectable(UICustomSelectable selectable, bool isSame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static InputType GetInpuTypeOf(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIsControllerInput(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPanelsGuideState(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable GetCurrentSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UITitlePanel GetTitlePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorPanel GetFloorPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIFilterPanel GetFilterPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBattleSettingPanel GetBattleSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIStoryArchivesPanel GetStoryArchivesPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBookPanel GetFeedBookPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIControlButtonPanel GetMenuPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIInvitationPanel GetInvitationPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBattleResultPanel GetBattleResultPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetPanelsNeighbor(UICustomSelectablePanel leftPanel, UICustomSelectablePanel rightPanel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIControlManager()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIControlManager()
		{
			throw null;
		}
	}
}
