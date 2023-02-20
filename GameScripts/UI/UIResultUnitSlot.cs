using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIResultUnitSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIBattleResultFloorSlot panel;

		public Animator anim;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private RectTransform rect;

		[SerializeField]
		private RectTransform rect_bgFrame;

		[SerializeField]
		private RectTransform rect_overlapBgFrame;

		[SerializeField]
		private RectTransform rect_innerlineframe;

		[SerializeField]
		private GameObject root_Portrait;

		[SerializeField]
		private RawImage rImg_portrait;

		[SerializeField]
		private Image img_DeadMark;

		[SerializeField]
		private TextMeshProUGUI txt_unitName;

		[SerializeField]
		private Image[] img_Frames;

		[SerializeField]
		private Image img_bg;

		[SerializeField]
		private Image img_overlapbg;

		[SerializeField]
		private UIGiftInfoPanel giftInfoPanel;

		private UnitBattleDataModel _unitdata;

		private float originSlotSize;

		private float slotoffsetsize;

		private bool isEmtpyGift;

		public UnitBattleDataModel Unitdata
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitBattleDataModel _data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimRevealStart()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartRevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimRevealEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIResultUnitSlot()
		{
			throw null;
		}
	}
}
