using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIAddedFeedBookList : UIOriginBookList, IScrollHandler, IEventSystemHandler
	{
		[Header("---Child---")]
		[Space(10f)]
		[SerializeField]
		private Button btn_nextPage;

		[SerializeField]
		private Button btn_prevPage;

		[SerializeField]
		private List<GameObject> upSelectableObjects;

		[SerializeField]
		private List<GameObject> downSelectableObjects;

		private List<LorId> _originBookIdList;

		private List<LorId> _currentBookIdList;

		[HideInInspector]
		public int currentPage;

		[HideInInspector]
		public int currentlistCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAddedFeedBooksData(List<LorId> books, bool init = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBookListPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateEmptyList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ExistsPrevPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ExistsNextPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetMaxPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPrevPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNextPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPage(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIBookPanel GetBookPanel()
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
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectable FindCurrentSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAddedFeedBookList()
		{
			throw null;
		}
	}
}
