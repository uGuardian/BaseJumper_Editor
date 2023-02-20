using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[Serializable]
	public class UICurtainBookPageList
	{
		public GameObject ActiveControl;

		public Image Title_Icon;

		public TextMeshProUGUI Title_Text;

		public UICurtainBookPageSlot[] Slots;

		private Color _defaultColor;

		private Color _highlightedColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNormal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICurtainBookPageList()
		{
			throw null;
		}
	}
}
