using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionCenterEquipBookSlot : MonoBehaviour
	{
		[Header("Reference")]
		public UIPassiveSuccessionCenterPanel panel;

		public RectTransform rect;

		public RectTransform rect_PassiveSlotsLayout;

		public Animator anim;

		public CanvasGroup cg;

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

		[Header("Passive")]
		[SerializeField]
		private List<UIPassiveSuccessionCenterPassiveSlot> passiveSlotList;

		[SerializeField]
		private Button button_UnEquipButton;

		[Header("Controller")]
		public UICustomSelectable firstSlotSelectable;

		public UICustomSelectable LastSlotSelectable;

		private BookModel _currentbookmodel;

		private const float offsetOriginFramesize = 50f;

		private const float offsetFrameSize = 35f;

		private const float offsetslotsize = 20f;

		private const float bookcontentsize = 45f;

		public bool isAnimSlot;

		public bool isOriginSlot;

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
		public UIPassiveSuccessionCenterPassiveSlot GetPassiveSlot(PassiveModel passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataOriginBook(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveList(List<PassiveModel> passivemodels, bool origin = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByRarity(Rarity rare)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffNormalSlotInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffAnimationSlotInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickReleaseButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterEquipBookSlot()
		{
			throw null;
		}
	}
}
