using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBookSlot : MonoBehaviour
	{
		[Header("Reference")]
		public RectTransform Pivot;

		[SerializeField]
		protected CanvasGroup cg;

		[SerializeField]
		public UICustomSelectable selectable;

		[Header("Frames")]
		[SerializeField]
		protected Image Frame;

		[SerializeField]
		protected Image FrameGlow;

		[SerializeField]
		protected Image Icon;

		[SerializeField]
		protected Image IconGlow;

		[SerializeField]
		protected TextMeshProUGUI BookName;

		[HideInInspector]
		public int originSiblingIdx;

		[HideInInspector]
		public int stringAscendidx;

		protected LorId _bookId;

		protected DropBookXmlInfo bookInfo;

		protected bool isDisabled;

		public DropBookXmlInfo DropBookInfo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public LorId BookId
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
		public void SetActivatedSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetActiveState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetData_DropBook(LorId bookId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEmptyViewSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGlowColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlighted(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookSlot()
		{
			throw null;
		}
	}
}
