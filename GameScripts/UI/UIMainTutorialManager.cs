using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIMainTutorialManager : SingletonBehavior<UIMainTutorialManager>
	{
		[Header("Reference")]
		[SerializeField]
		private Sprite sp_highlightRotation;

		[SerializeField]
		private Transform highlightedFrameParent;

		[Header("Battle Setting Start")]
		public UITutorialAutoAlarmTemplate BattleSettingStartTemplate;

		[Header("Battle Result")]
		[SerializeField]
		private UITutorialAutoAlarmTemplate battleResultTemplate;

		[Header("FeedBook Template")]
		public UITutorialAutoAlarmTemplate FeedBookTutorialTemplate;

		[Header("BattlePage Tutorial")]
		[SerializeField]
		private UITutorialAutoAlarmTemplate BattlePageTutorialTemplate;

		[Header("Equippage Tutorial")]
		[SerializeField]
		private UITutorialAutoAlarmTemplate OpenEquipPagePhaseTutorialTemplate;

		[SerializeField]
		public UITutorialAutoAlarmTemplate ClickEquipPageTutorialTemplate;

		[SerializeField]
		private UITutorialAutoAlarmTemplate ChangeEquipPageTutorialTemplate;

		[Header("Librarian Info")]
		[SerializeField]
		private UITutorialAutoAlarmTemplate LibrarianTutorialTemplate;

		[Header("Keter Levelup Tutorial")]
		[SerializeField]
		private UITutorialAutoAlarmTemplate keterLevelupTutorialAlarmTemplate;

		[Header("BattleSetting Remain Stage")]
		[SerializeField]
		private UITutorialAutoAlarmTemplate RemainStageButtonHighlightTemplate;

		[SerializeField]
		public UITutorialAutoAlarmTemplate RemainStageTemplate;

		[Header("BattleSetting Possible Floor")]
		[SerializeField]
		public UITutorialAutoAlarmTemplate PossibleFloorTemplate;

		[Header("Open Malkuth")]
		[SerializeField]
		public UITutorialAutoAlarmTemplate openMalkuthTemplate;

		public List<GameObject> ob_Frames;

		private List<UITutorialAutoAlarmTemplate> templateList;

		public UIMainTutorialManager.OnEquipPageClickEndTutorial endEquipPageClickFuncForTutorial;

		private GameObject previewequipInfoHighlightframe;

		private GameObject equipbuttonhighlightFrame;

		private Canvas previewcanvas;

		private int previeworiginsortorder;

		public readonly int keterLevelUpCondition_StageID;

		private GameObject wavebuttonHighlightedFrame;

		public UIMainTutorialManager.OnWaveButtonClickEndTutorial endWaveButtonClickFuncForTutorial;

		public readonly int remainwaveTutorial_StageID;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBattleSettingStartTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBattleResultTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFeedBookTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBattlePageTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartLibrarianInfoTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartKeterLevelUpTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEquipPageOpenTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEquipPageClickTutorial(RectTransform previewrect, RectTransform equipbuttonrect)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestoryButtonHighlight(bool init = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEquipPageChangeTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBattleSettingRemainStageTutorial(RectTransform wavebuttonrect)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBattleSettingRemainStageButtonTemplate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestoryWaveTutorialInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBattleSettingPossibleFloorTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartOpenMalkuthTutorial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsOpenedTutorialPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainTutorialManager()
		{
			throw null;
		}

		public delegate void OnEquipPageClickEndTutorial(bool clicked, RectTransform target);

		public delegate void OnWaveButtonClickEndTutorial();
	}
}
