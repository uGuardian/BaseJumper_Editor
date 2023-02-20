using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[Serializable]
	internal struct LevelUPAbilitySlot
	{
		public GameObject Root;

		public TextMeshProUGUI abilityContent;

		public Image img_FrameImage;

		public Image img_bg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UIAbilitySlotTextData textdata)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGlowColor(Color c)
		{
			
		}
	}
}
