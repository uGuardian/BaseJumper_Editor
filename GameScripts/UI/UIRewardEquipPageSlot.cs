﻿using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIRewardEquipPageSlot : UIOriginEquipPageSlot
	{
		[Header("---Child---")]
		[SerializeField]
		private GameObject ob_PerAlarm;

		[SerializeField]
		private Image img_perframe;

		[SerializeField]
		private TextMeshProUGUI txt_PerAlarmText;

		private BookXmlInfo _book;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetActiveSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRewardData(UIRewardBookData book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIRewardEquipPageSlot()
		{
			throw null;
		}
	}
}
