using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UISlot : MonoBehaviour
	{
		[Header("UISlot Reference")]
		public RectTransform Pivot;

		public UICustomSelectable Selectable;

		protected bool isSelected;

		protected bool isDisabled;

		protected Color originalColor;

		protected Color originalGlowColor;

		protected Color highlightedColor;

		public bool IsSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSize(float sizeFactor = 1f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsMouseInputValid(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerDown(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerUp(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerClick(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSelected(bool selected)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlighted(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISlot()
		{
			throw null;
		}
	}
}
