using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIFloorTitlePanel : MonoBehaviour
	{
		[SerializeField]
		private Image img_floorTitle;

		[SerializeField]
		private TextMeshProUGUI txt_titlename;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorTitlePanel()
		{
			throw null;
		}
	}
}
