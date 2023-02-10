using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace UI
{
	public class UIDetailCardSlot : UIOriginCardSlot
	{
		[Header("---Child---")]
		[Space(10f)]
		[Header("Right Panel")]
		[SerializeField]
		private GameObject ob_selfAbility;

		[SerializeField]
		private TextMeshProUGUI txt_selfAbility;

		[SerializeField]
		private List<UIDetailCardDescSlot> rightDescSlotList;

		[Header("Keyword")]
		[SerializeField]
		private KeywordListUI keywordListUI_R;

		[SerializeField]
		private KeywordListUI keywordListUI_L;

		[Header("Inspector Setting")]
		[SerializeField]
		private bool OnKeyword;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(DiceCardItemModel cardmodel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDetailCardSlot()
		{
			throw null;
		}
	}
}
