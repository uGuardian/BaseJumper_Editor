using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIBookStoryPanel : MonoBehaviour
	{
		public UIStoryArchivesPanel panel;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[Header("Book List")]
		[SerializeField]
		private List<UIBookStoryChapterSlot> bookStoryChapterSlots;

		[SerializeField]
		private VerticalLayoutGroup slotsLayoutGroup;

		public List<UIBookStoryBookSlot> bookSlots;

		[SerializeField]
		private GameObject selectedEpisodeTitleRect;

		[SerializeField]
		private TextMeshProUGUI selectedEpisodeText;

		[SerializeField]
		private Image selectedEpisodeIcon;

		[SerializeField]
		private Image selectedEpisodeIconGlow;

		[SerializeField]
		private GameObject nullEpisodeRect;

		[SerializeField]
		private Image BookListLayout;

		[SerializeField]
		private CustomButton bookListUpButton;

		[SerializeField]
		private CustomButton bookListDownButton;

		[SerializeField]
		private List<GameObject> upSelectableObjects;

		[SerializeField]
		private List<GameObject> downSelectableObjects;

		[SerializeField]
		private ScrollRect episodeListScroll;

		public UICustomSelectablePanel SelectablePanel_epis;

		public UICustomSelectablePanel SelectablePanel_books;

		public UICustomSelectablePanel SelectablePanel_Text;

		[Header("Right Panel")]
		[SerializeField]
		private Image portrait;

		[SerializeField]
		private Image cgImage;

		[SerializeField]
		private UIOriginEquipPageSlot equipPageSlot;

		[SerializeField]
		private TextMeshProUGUI equipPageName;

		[SerializeField]
		private TextMeshProUGUI equipPageStory;

		[SerializeField]
		private UIScrollbarController scrollbar;

		public UICustomSelectable storyTextSelectable;

		private BookModel bookItem;

		private int[] episodeIdx;

		[HideInInspector]
		public UIBookStoryChapterSlot curChapterSlot;

		[HideInInspector]
		public UIBookStoryBookSlot curBookSlot;

		private int bookListPageIndex;

		private List<BookXmlInfo> bookListData;

		private List<BookXmlInfo> currentScreenBookList;

		private bool isTextAreaSelected;

		private float scrollspeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectChapterSlot(UIBookStoryChapterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectEpisodeSlot(UIBookStoryEpisodeSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectBook(UIBookStoryBookSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowEquipPageStory(UIBookStoryBookSlot model)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateLayoutGroup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmitChapterSlot(UIBookStoryChapterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelChapterSlot(UIBookStoryChapterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBookSlots()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScrollEnter(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScrollBookList(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScrollEpisodeList(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int[] GetEpisodeIdx()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject(int column)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObjet(int column)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectTextSelectable(bool isSelected)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FocusOn(UIBookStoryEpisodeSlot epSlot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FocusOn(UIBookStoryChapterSlot chSlot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelBooks()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelTextScroll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookStoryPanel()
		{
			throw null;
		}
	}
}
