using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UILibrarySliderPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private Image img_CityIcon;

		[SerializeField]
		private Image img_CityIconGlow;

		[SerializeField]
		private TextMeshProUGUI txt_leveltxt;

		[SerializeField]
		private Image img_SliderMaskGauge;

		[SerializeField]
		private float sliderLength;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarySliderPanel()
		{
			throw null;
		}
	}
}
