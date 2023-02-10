using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIStoryArchivesPanel : UIPanel
	{
		public UISephirahStoryPanel sephirahStoryPanel;

		public UIBattleStoryPanel battleStoryPanel;

		public UIBookStoryPanel bookStoryPanel;

		public UICreatureRebattlePanel creatureRebattlePanel;

		[SerializeField]
		private UICustomTabsController tabcontroller;

		private List<BookXmlInfo> episodeBooksData;

		private List<BookXmlInfo> chapterBooksData;

		[Header("Controller")]
		public GameObject ControllerGuide;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TabControllerUpdated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryProgressPanel GetStoryProgressPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookXmlInfo> GetEpisodeBooksDataAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookXmlInfo> GetEpisodeBooksData(UIStoryLine ep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookXmlInfo> GetChapterBooksData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookXmlInfo> GetChapterBooksData(int chap)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isController)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryArchivesPanel()
		{
			throw null;
		}
	}
}
