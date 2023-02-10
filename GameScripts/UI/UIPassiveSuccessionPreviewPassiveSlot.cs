using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionPreviewPassiveSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIPassiveSuccessionPreviewBookPanel panel;

		public RectTransform rect;

		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private Image img_UsingFrameGlow;

		[SerializeField]
		private TextMeshProUGUI txt_Name;

		[SerializeField]
		private TextMeshProUGUI txt_Desc;

		[Header("UsingAlarm")]
		[SerializeField]
		private GameObject ob_UsingAlarm;

		[Header("LevelLock")]
		[SerializeField]
		private GameObject ob_LevelLock;

		[SerializeField]
		private TextMeshProUGUI txt_needLevel;

		[SerializeField]
		private List<Graphic> graphics_Rarity;

		[Header("Cost")]
		[SerializeField]
		private TextMeshProUGUI txt_Cost;

		private PassiveModel passivemodel;

		private const float minSlotHeight = 30f;

		private const float originframeoffset = 29f;

		private const float textoffset = 12f;

		public bool isAnimSlot;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(PassiveModel passive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSize(float height)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByRarity(Rarity rare)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByRarity(Color color)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorByUsing(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionPreviewPassiveSlot()
		{
			throw null;
		}
	}
}
