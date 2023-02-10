using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[Serializable]
	public struct storyIconLevel
	{
		public GameObject root;

		public Image img_iconbg;

		public Image img_iconFrame;

		public TextMeshProUGUI txt_iconContent;

		public UICustomSelectable selectable;
	}
}
