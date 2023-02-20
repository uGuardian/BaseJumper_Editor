using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIGachaEquipSlot : MonoBehaviour
	{
		public Image Frame;

		public Image FrameGlow;

		public Image Icon;

		public Image IconGlow;

		public TextMeshProUGUI BookName;

		public CanvasGroup cg;

		public BookModel _book;

		[HideInInspector]
		public int index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(BookModel book, int slotIdx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetGlowColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightedColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGachaEquipSlot()
		{
			throw null;
		}
	}
}
