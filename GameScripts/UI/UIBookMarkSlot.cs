using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIBookMarkSlot : MonoBehaviour
	{
		[Header("BookMarkSlot")]
		[SerializeField]
		protected Image img_SlotFrame;

		[HideInInspector]
		protected bool isSelected;

		[HideInInspector]
		protected bool isDisabled;

		protected Color currentColor;

		protected Color originColor;

		public bool IsSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEnterPointer(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnExitPointer(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClickSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDisabled(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlightedColor(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookMarkSlot()
		{
			throw null;
		}
	}
}
