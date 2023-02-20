using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIEquipPageModelPreviewPanel : MonoBehaviour
	{
		[Header("Reference")]
		public RectTransform rect;

		[SerializeField]
		private Graphic[] graphic_Frames;

		public CanvasGroup cg;

		public RectTransform rect_LeftArrow;

		public RectTransform rect_RightArrow;

		[Header("Stat")]
		[SerializeField]
		private Image img_Portrait;

		[SerializeField]
		private Image img_BookIconGlow;

		[SerializeField]
		private Image img_BookIcon;

		[SerializeField]
		private TextMeshProUGUI txt_BookName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_bookname;

		[SerializeField]
		private UICharacterStatInfoPanel StatsInfo;

		[Header("Passive")]
		[SerializeField]
		private UISetInfoSlotListSc passiveSlotsPanel;

		private BookModel bookDataModel;

		public bool isActive
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
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageModelPreviewPanel()
		{
			throw null;
		}
	}
}
