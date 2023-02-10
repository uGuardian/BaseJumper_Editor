using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace UI
{
	public class UIAbnormalityCategoryPanel : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI txt_Title;

		public GameObject root;

		[SerializeField]
		private List<UIAbnormalityCardPreviewSlot> cardList;

		[SerializeField]
		private GameObject LockImage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<EmotionCardXmlInfo> data, int index, UIAbnormalityPanel panel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLock()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityCardPreviewSlot GetFirstSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityCategoryPanel()
		{
			throw null;
		}
	}
}
