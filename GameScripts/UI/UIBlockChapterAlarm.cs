using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[Serializable]
	public struct UIBlockChapterAlarm
	{
		public GameObject root;

		public Image img_icon;

		public Image img_iconglow;

		public TextMeshProUGUI txt_alarm;
	}
}
