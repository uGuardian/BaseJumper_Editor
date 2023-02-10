using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICustomTabButton : MonoBehaviour
	{
		public TextMeshProUGUI TabName;

		public UICustomSelectable selectable;

		public bool IsSelected;

		[SerializeField]
		private Image[] frames;

		[SerializeField]
		private Image[] highlightFrames;

		private int Index;

		private UICustomTabsController Controller;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int _index, UICustomTabsController _controller)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHighlight(bool isHighlighted, bool isSelected = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color color)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseEntered()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseExited()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseClicked()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomTabButton()
		{
			throw null;
		}
	}
}
