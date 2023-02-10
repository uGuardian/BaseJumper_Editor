using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIManualContentPanel : UIPopup
	{
		private static UIManualContentPanel _instance;

		private const string ScreenShotPath = "Sprites/ManualScreenShot/";

		[Header("Reference")]
		[SerializeField]
		private RectTransform contentList;

		[SerializeField]
		private GameObject manualBg;

		[SerializeField]
		private GameObject notmanualBg;

		[SerializeField]
		private Transform ManualParent;

		[SerializeField]
		private Transform NotManualParent;

		[SerializeField]
		private Animator anim;

		private Vector3 manualPos;

		private Vector3 notmanualPos;

		[SerializeReference]
		private Sprite[] ScreenShot;

		public List<ManualTitle> ManualContentData;

		public List<UIManualScreenPage> currentManualContents;

		private bool isOnlyContentPanel;

		private Dictionary<string, Sprite> screenShotDic;

		private UIManualScreenPage currentPage;

		private string currentLanguage;

		public UICustomSelectable selectable;

		public static UIManualContentPanel instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool _isonlycontentpanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenManualAndContent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenOnlyContent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseContentPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowContents(UIManualContentId ids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<UIManualScreenPage> FindSubTitleData(int titleid, int subtitleid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBackgroundType(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNextPageInManual(UIManualContentId ids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNextPageOnlyContent(UIManualContentId ids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualContentPanel()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIManualContentPanel()
		{
			throw null;
		}
	}
}
