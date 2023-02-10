using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionPreviewBookPanel : MonoBehaviour
	{
		[Header("Reference")]
		public RectTransform rect;

		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private TextMeshProUGUI txt_name;

		[SerializeField]
		private TextMeshProMaterialSetter setter_name;

		[SerializeField]
		private Image img_IconGlow;

		[SerializeField]
		private Image img_Icon;

		public RectTransform rect_Arrow;

		[Header("Passive")]
		[SerializeField]
		private RectTransform rect_Passivelist;

		[SerializeField]
		private List<UIPassiveSuccessionPreviewPassiveSlot> passiveSlotList;

		[Header("AnimationPassive")]
		[SerializeField]
		private RectTransform rect_animPassiveList;

		[SerializeField]
		private List<UIPassiveSuccessionPreviewPassiveSlot> AnimPassiveSlotList;

		private const float offsetFramesize = 25f;

		private const float offsetslotsize = 20f;

		private const float bookcontentsize = 75f;

		private BookModel _currentbookmodel;

		public BookModel CurrentBookModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveList(List<PassiveModel> passivemodels)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByRarity(Rarity rare)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionPreviewBookPanel()
		{
			throw null;
		}
	}
}
