using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIRewardCardSlot : UIOriginCardSlot
	{
		[SerializeField]
		private GameObject ob_peralarm;

		[SerializeField]
		private Image img_perframe;

		[SerializeField]
		private TextMeshProUGUI txt_peralarmtext;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRewardData(UIRewardCardData card)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIRewardCardSlot()
		{
			throw null;
		}
	}
}
