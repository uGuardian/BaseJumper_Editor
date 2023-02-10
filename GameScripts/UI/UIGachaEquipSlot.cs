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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetGlowColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightedColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGachaEquipSlot()
		{
			throw null;
		}
	}
}
