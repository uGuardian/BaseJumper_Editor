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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHighlight(bool isHighlighted, bool isSelected = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color color)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseEntered()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseExited()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnMouseClicked()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomTabButton()
		{
			throw null;
		}
	}
}
