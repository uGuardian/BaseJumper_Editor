using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Workshop;

namespace UI
{
	public class UICustomCoreBookInfoPanel : MonoBehaviour
	{
		[Header("UpperPanel Resources")]
		[SerializeField]
		private UICharacterBookSlot currentBook;

		[Header("Root")]
		[SerializeField]
		private GameObject rewardRoot;

		[SerializeField]
		private GameObject contentRoot;

		[Header("Book Basic Data")]
		[SerializeField]
		private TextMeshProUGUI txt_bookName;

		[SerializeField]
		private TextMeshProUGUI txt_rarity;

		[SerializeField]
		private Image img_Portrait;

		[Header("Book Content Data")]
		[SerializeField]
		private TextMeshProUGUI txt_bookSubTitle;

		[SerializeField]
		private TextMeshProUGUI txt_BookContentText;

		[Header("Frame For Color")]
		[SerializeField]
		private Graphic[] img_Frames;

		[Header("Tab")]
		[SerializeField]
		private UITabButton rewardTab;

		[SerializeField]
		private UITabButton contentTab;

		[Header("Ability")]
		[SerializeField]
		private CanvasGroup cg;

		private IEnumerator RevealProcess;

		private bool isShowBookContent;

		private bool isDisabled;

		public Vector2 OriginContentSize;

		private Coroutine revealdata;

		public float alphacount;

		public float alphaspeed;

		private bool isrunningAlpha;

		private float startAlpha;

		private float targetAlpha;

		public IEnumerator _revealProcess
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowWorkshopInfo(string workshopItemIdx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowCustomCoreBookInfoData(int bookid, bool isShow = true)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDataRewardData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetWorkshopRewardData(WorkshopSkinData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBookContentData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetWorkshopContentData(WorkshopSkinData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBookFrame()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickBookTab()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickContentTab()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetShowDataState(bool showContent)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByPhaseType(UIPhase currentPhase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyColorAll()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowAllTabButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideAllTabButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetShowData(bool show)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataReveal(bool show)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealAlphaProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomCoreBookInfoPanel()
		{
			throw null;
		}
	}
}
