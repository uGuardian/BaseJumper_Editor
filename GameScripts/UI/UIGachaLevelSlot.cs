using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIGachaLevelSlot : MonoBehaviour
	{
		public int startlevel;

		public Image levelprev;

		public Image levelnext;

		[HideInInspector]
		public Image currentImage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentImage(int currentlv)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGachaLevelSlot()
		{
			throw null;
		}
	}
}
