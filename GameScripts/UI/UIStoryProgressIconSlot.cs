using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIStoryProgressIconSlot : UISlot
	{
		private UIStoryProgressPanel StoryProgressPanel;

		public UIStoryLine currentStory;

		[Header("StorySlot Reference")]
		[Header("Close Icon")]
		[SerializeField]
		private GameObject closeRect;

		[SerializeField]
		private Animator anim_closeRect;

		[SerializeField]
		private CanvasGroup cg_closeRect;

		[SerializeField]
		private Image img_highlighted;

		[SerializeField]
		private StoryIconSet closeIconset;

		[Header("Open Icon")]
		[SerializeField]
		private GameObject openRect;

		[SerializeField]
		private GameObject openFrameTarget;

		[SerializeField]
		private StoryIconSet openIconset;

		[SerializeField]
		private storyIconLevel[] iconset_Level;

		[Header("Line")]
		[SerializeField]
		private List<GameObject> connectLineList;

		[Header("ChapterIcon")]
		[SerializeField]
		private bool isChapterIcon;

		public List<UICustomSelectable> ChapterSelectables;

		public UICustomGraphicObject ChapterStoryButton;

		[SerializeField]
		private Grade currentGrade;

		[SerializeField]
		private Image img_icon;

		[SerializeField]
		private Image img_iconbg;

		[SerializeField]
		private Image img_openicon;

		[SerializeField]
		private Image img_openiconbg;

		[SerializeField]
		private TextMeshProUGUI txt_chaptergrade;

		[SerializeField]
		private TextMeshProUGUI txt_openChapterName;

		[SerializeField]
		private GameObject ob_level1iconhighlighted;

		private List<StageClassInfo> storyData;

		private int storyId;

		public int currentSelectedLevelIndex;

		private Color originalcolor;

		private Color glowOriginalColor;

		private int selectedIndex;

		private float startsize;

		private float endsize;

		private float speed;

		private float count;

		private bool isRunningOpenpanelProcess;

		private Coroutine openPanelProcess;

		public storyIconLevel[] IconLevels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool _ischapterIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Grade CurrentGrade
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<StageClassInfo> _storyData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public RectTransform Rect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized(UIStoryProgressPanel panel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotData(List<StageClassInfo> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetIcon(UIIconManager.IconSet icondata)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotOpen(bool open)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLevelUIColor(Color c, int level)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveStory(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveLine(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChapterLineEnter(int i)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClickMainIcon()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetHighlighted(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickOpenFrame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterLevelIcon(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitLevelIcon(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickLevelIcon(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectChapterStoryButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickStoryLevelIcon(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLevelClick(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultStoryLevel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealOpenPanel(bool show)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealOpenPanelProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetChapterStoryIconDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetChapterStoryIcon()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButton(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButtonAbnormality()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryProgressIconSlot()
		{
			throw null;
		}
	}
}
