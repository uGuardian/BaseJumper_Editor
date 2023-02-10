using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIOriginEquipPageSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		protected RectTransform Pivot;

		public RectTransform rect;

		[SerializeField]
		private CanvasGroup cg;

		[Header("Frame")]
		[SerializeField]
		protected Image Frame;

		[SerializeField]
		protected Image FrameGlow;

		[SerializeField]
		protected Image img_selectbg;

		[SerializeField]
		protected Animator anim_selectedbg;

		[SerializeField]
		protected Image img_selectedgehighlight;

		[SerializeField]
		protected Animator anim_selectedhighlight;

		[SerializeField]
		protected Image Icon;

		[SerializeField]
		protected Image IconGlow;

		[SerializeField]
		protected TextMeshProUGUI BookName;

		[SerializeField]
		protected TextMeshProMaterialSetter setter_BookName;

		public UICustomSelectable selectable;

		protected BookModel _bookDataModel;

		protected UIEquipPageSlotState currenSlotState;

		protected bool isEmptyBook;

		public BookModel BookDataModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsEmptyBook
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetData(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetActiveSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool on, bool isClick = false, bool padselect = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetColorFrame(UIEquipPageSlotState type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetGlowColor(Color gc)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffPadSelectHighlighted()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetActiveOperatinPanel(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOriginEquipPageSlot()
		{
			throw null;
		}
	}
}
