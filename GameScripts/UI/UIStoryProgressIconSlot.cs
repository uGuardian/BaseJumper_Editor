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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotData(List<StageClassInfo> data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetIcon(UIIconManager.IconSet icondata)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotOpen(bool open)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLevelUIColor(Color c, int level)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveStory(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveLine(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChapterLineEnter(int i)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClickMainIcon()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetHighlighted(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickOpenFrame()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterLevelIcon(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitLevelIcon(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickLevelIcon(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectChapterStoryButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickStoryLevelIcon(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLevelClick(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultStoryLevel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealOpenPanel(bool show)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealOpenPanelProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetChapterStoryIconDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetChapterStoryIcon()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButton(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButtonAbnormality()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryProgressIconSlot()
		{
			throw null;
		}
	}
}
