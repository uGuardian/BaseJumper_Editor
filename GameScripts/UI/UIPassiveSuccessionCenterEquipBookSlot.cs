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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterPassiveSlot GetPassiveSlot(PassiveModel passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataOriginBook(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveList(List<PassiveModel> passivemodels, bool origin = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByRarity(Rarity rare)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffNormalSlotInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffAnimationSlotInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickReleaseButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionCenterEquipBookSlot()
		{
			throw null;
		}
	}
}
