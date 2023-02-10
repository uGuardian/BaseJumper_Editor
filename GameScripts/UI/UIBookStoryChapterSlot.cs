using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIBookStoryChapterSlot : MonoBehaviour
	{
		[SerializeField]
		private UIBookStoryPanel panel;

		public RectTransform rect;

		[SerializeField]
		private TextMeshProUGUI chapterText;

		[SerializeField]
		private TextMeshProMaterialSetter textSetter;

		[SerializeField]
		private Image chapterIcon;

		[SerializeField]
		private Image chapterIconGlow;

		[SerializeField]
		private RectTransform EpisodeSlotsListRect;

		[SerializeField]
		private UIBookStoryEpisodeSlot EpisodeSlotModel;

		public float rectDefaultHeight;

		[Header("Controller")]
		public UICustomSelectable selectable;

		[HideInInspector]
		public int chapter;

		private int[] episodeIdx;

		private List<UIBookStoryEpisodeSlot> EpisodeSlots;

		[HideInInspector]
		public UIBookStoryEpisodeSlot curEpisodeSlot;

		private bool isShowing;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int chap)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightColor(bool isHighlight)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InstatiateAdditionalSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEpisodeSlots()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowEpisodeSlots()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideEpisodeSlots()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBookSlots(UIBookStoryEpisodeSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FocusOn(UIBookStoryEpisodeSlot epslot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookStoryChapterSlot()
		{
			throw null;
		}
	}
}
