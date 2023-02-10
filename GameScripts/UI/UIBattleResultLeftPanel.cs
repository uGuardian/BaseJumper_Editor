using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleResultLeftPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private RectTransform rect;

		[SerializeField]
		private RectTransform viewport;

		[SerializeField]
		private UILoseBookPanel loseBookPanel;

		[SerializeField]
		private GameObject getBookListTitlePanel;

		[SerializeField]
		private UIResultRewardDropBookList dropBookListPanel;

		[SerializeField]
		private UIResultRewardDropBookList addedDropBookListPanel;

		[SerializeField]
		private UIDropPageList rewardCardlistPanel;

		[SerializeField]
		private RectTransform rect_GetBookTitleAlarm;

		[SerializeField]
		private RectTransform root_listparent;

		[SerializeField]
		private List<UIResultGetBookAlarmSlot> getBookPerAlarmSlot;

		[SerializeField]
		private RectTransform rect_GetListRoot;

		[SerializeField]
		private RectTransform rect_AddedGetListRoot;

		[SerializeField]
		private Button button_DownArrow;

		[SerializeField]
		private Button button_UpArrow;

		private float originGetBookOffset;

		private float originGetBookSlotHeight;

		private float addedgetbooklistoffset;

		private bool iswin;

		public float arrowWheelspeed;

		private bool isClickedLowerArrow;

		private bool isClickedUpperArrow;

		public bool getRewardCardForKeter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void scrollUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void scrollDown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(TestBattleResultData resultdata)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataRewardCards(List<BookDropResult> pages)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownLowerArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUpLowerArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownUpperArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUpUpperArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpdateArrowButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleResultLeftPanel()
		{
			throw null;
		}
	}
}
