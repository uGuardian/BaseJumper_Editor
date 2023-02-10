using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIEquipBookSlot : MonoBehaviour
	{
		public Image Frame;

		public Image FrameGlow;

		public Image Icon;

		public Image IconGlow;

		public TextMeshProUGUI BookName;

		private BookXmlInfo _book;

		[SerializeField]
		private GameObject ob_peralarm;

		[SerializeField]
		private Image img_perframe;

		[SerializeField]
		private TextMeshProUGUI txt_peralarmtext;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UIRewardBookData book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPerData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGlowColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipBookSlot()
		{
			throw null;
		}
	}
}
