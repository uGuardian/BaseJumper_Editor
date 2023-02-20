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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightColor(bool isHighlight)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InstatiateAdditionalSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEpisodeSlots()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowEpisodeSlots()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideEpisodeSlots()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBookSlots(UIBookStoryEpisodeSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FocusOn(UIBookStoryEpisodeSlot epslot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookStoryChapterSlot()
		{
			throw null;
		}
	}
}
