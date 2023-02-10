using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICustomizeProfile : UICustomPanel
	{
		[Header("Reference")]
		[SerializeField]
		private TextMeshProUGUI txt_Name;

		[SerializeField]
		private RawImage rimg_Portrait;

		[SerializeField]
		private List<TextMeshProUGUI> previewScriptTxtList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(UICustomizePopup parent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePortrait()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateScript()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeProfile()
		{
			throw null;
		}
	}
}
