using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UITitleRearPanel : UIPanel
	{
		public GameObject DefaultTitle;

		public GameObject GameStartTitle;

		public GameObject battleResultTitle;

		public List<MaskableGraphic> MainApplied;

		public List<MaskableGraphic> GlowApplied;

		public List<MaskableGraphic> BackApplied;

		public List<TextMeshProUGUI> TitleTexts;

		public UITitleRearPanel.ColorSet GreenSet;

		public UITitleRearPanel.ColorSet OrangeSet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhaseTransition(UIPhase prev, UIPhase next)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseEnter(UIPhase phase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(UITitleRearPanel.ColorSet set)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITitleRearPanel()
		{
			throw null;
		}

		[Serializable]
		public class ColorSet
		{
			public Color MainColor;

			public Color BackColor;

			public Color GlowColor;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ColorSet()
			{
				throw null;
			}
		}
	}
}
