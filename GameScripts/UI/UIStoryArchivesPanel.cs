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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TabControllerUpdated()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryProgressPanel GetStoryProgressPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitData()
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLTEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryArchivesPanel()
		{
			throw null;
		}
	}
}
