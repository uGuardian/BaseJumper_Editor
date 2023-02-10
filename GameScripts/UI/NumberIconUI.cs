using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[Serializable]
	public struct NumberIconUI
	{
		public GameObject root;

		public Image bg;

		public Image content;

		public Image linear;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetImageComponent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSprite(NumberIconSet iconset)
		{
			throw null;
		}
	}
}
