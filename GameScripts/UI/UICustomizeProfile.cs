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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateName()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePortrait()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateScript()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeProfile()
		{
			throw null;
		}
	}
}
