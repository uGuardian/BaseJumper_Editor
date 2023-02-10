using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIStoryProgressPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		public Color chapterOriginColor;

		[Header("StoryLine")]
		[SerializeField]
		private RectTransform sizeRect;

		[SerializeField]
		private RectTransform posRect;

		[SerializeField]
		private RectTransform rect_viewPort;

		[SerializeField]
		private ScrollRect scroll_viewPort;

		[SerializeField]
		private List<UIStoryProgressIconSlot> iconList;

		[SerializeField]
		private List<GameObject> chapterList;

		[Header("Xbox")]
		public UICustomSelectablePanel SelectablePanel;

		public bool JustReadStory;

		[Header("Filter")]
		[SerializeField]
		private UIStoryGradeFilter gradeFilter;

		[HideInInspector]
		public UIStoryProgressIconSlot currentSlot;

		[SerializeField]
		private List<UIStoryProgressIconSlot> chapterIconList;

		[SerializeField]
		private List<UIBlockChapterAlarm> blockChapterList;

		private float possibleHeight;

		private float viewportWideSize;

		private float viewportOirignSize;

		private readonly float maxscale;

		private readonly float minscale;

		[SerializeField]
		private float sensitivity;

		private float defaultZoom;

		private Vector3 targetScale;

		private Vector3 startscale;

		private float scaleCount;

		private bool isRunningScale;

		private Vector2 targetpos;

		private Vector2 startpos;

		private float moveCount;

		private bool isRunningMove;

		private UIInvitationPanel invitationPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private UIBattleStoryPanel battleStoryPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStoryLine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSelectFirstSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseWheel(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetWheelZoom(float value, bool immediately = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRectSize(float value, bool immediately)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ZoomProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRectPos(Vector2 target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator MoveProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsShowChapterBlock(int chapter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetViewPortSize(bool wide)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MoveIconTarget(UIStoryProgressIconSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveIconTarget(Vector2 slotpos, bool immediately = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MoveChapterTarget(UIStoryProgressIconSlot slot, bool immediately = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MoveChapterTarget(int chapter, bool immediately = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckOpenStory(int chapter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectedSlot(UIStoryProgressIconSlot slot, bool isSelected)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectedStory(bool _show, int index, bool applyleft = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlockData(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSelectableToProgress()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryProgressPanel()
		{
			throw null;
		}
	}
}
