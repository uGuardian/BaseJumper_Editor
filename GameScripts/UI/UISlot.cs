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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSize(float sizeFactor = 1f)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsMouseInputValid(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerDown(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerUp(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerClick(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSelected(bool selected)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlighted(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISlot()
		{
			throw null;
		}
	}
}
