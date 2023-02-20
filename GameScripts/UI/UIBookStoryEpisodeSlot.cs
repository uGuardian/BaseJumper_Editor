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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int chapter, List<BookXmlInfo> data, UIBookStoryChapterSlot panelData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlight(bool isHighlight)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookStoryEpisodeSlot()
		{
			throw null;
		}
	}
}
