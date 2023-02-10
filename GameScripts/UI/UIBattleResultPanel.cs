using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIBattleResultPanel : UIPanel
	{
		[Header("RightPanel")]
		[SerializeField]
		private UIBattleResultLeftPanel leftPanel;

		[Header("CenterPanel")]
		[SerializeField]
		private UIBattleResultSephirahListPanel centerPanel;

		[Header("LeftPanel")]
		[SerializeField]
		private UIBattleResultFloorSlot rightPanel;

		[SerializeField]
		private Animator anim_rightpanel;

		[SerializeField]
		private UIBattleResultAnimationFloorSlot rightAnimPanel;

		[Header("Cloud")]
		[SerializeField]
		private UIMainProcessPanel frontCloudProcess;

		[SerializeField]
		private RectTransform rect_FrontCloud;

		[Header("Controller")]
		public UICustomSelectablePanel LeftSelectablePanel;

		public UICustomSelectable RightSelecable;

		[SerializeField]
		private GameObject ControllerGuide;

		private readonly Vector3 sepirothSize;

		private readonly Vector2 sepirothPos;

		private StageModel currentStage;

		private SephirahType currentSephirah;

		private SephirahType nextSep;

		private SephirahType prevSep;

		private List<SephirahType> _sepOrderList;

		private TestBattleResultData resultWavedata;

		[Range(0f, 20f)]
		public float floorRevealspeed;

		[Range(0f, 20f)]
		public float enemyRevealinterval;

		[Range(0f, 50f)]
		public float floorRevealInterval;

		private int scrollablePanel;

		public UIBattleResultLeftPanel LeftPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public StageModel _currentStage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public SephirahType _currentSephirah
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
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
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
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
		public void SetData(TestBattleResultData resultdata)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TestBattleResultData GetResultData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetRightPanelDataBySephirah(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRightFloorButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickFloorUpperButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickFloorLowerButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageLibraryFloorModel GetFloor(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickEndBattleButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSepiroth()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainPanel GetMainPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RectTransform GetSepirothPivot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObjet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetScrollablePanel(int panelNum)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isController)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleResultPanel()
		{
			throw null;
		}
	}
}
