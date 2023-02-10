using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIBookStoryEpisodeSlot : MonoBehaviour
	{
		public RectTransform rect;

		[SerializeField]
		private TextMeshProUGUI episodeText;

		[SerializeField]
		private TextMeshProMaterialSetter textSetter;

		[SerializeField]
		private Image episodeIcon;

		[SerializeField]
		private Image episodeIconGlow;

		public UICustomSelectable selectable;

		[HideInInspector]
		public UIBookStoryChapterSlot rootChapter;

		[HideInInspector]
		public List<BookXmlInfo> books;

		[HideInInspector]
		public int episode;

		[HideInInspector]
		public bool isEtc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(List<BookXmlInfo> data, UIBookStoryChapterSlot panelData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int chapter, List<BookXmlInfo> data, UIBookStoryChapterSlot panelData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlight(bool isHighlight)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookStoryEpisodeSlot()
		{
			throw null;
		}
	}
}
