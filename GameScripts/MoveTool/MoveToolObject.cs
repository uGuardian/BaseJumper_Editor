using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace MoveTool
{
	[Serializable]
	public class MoveToolObject
	{
		public Image Arrow;

		public Image Bar;

		public Color NormalColor;

		public Color ClickedColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(ColorType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MoveToolObject()
		{
			throw null;
		}
	}
}
