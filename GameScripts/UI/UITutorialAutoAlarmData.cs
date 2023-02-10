using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	[Serializable]
	public class UITutorialAutoAlarmData
	{
		public RectTransform rect;

		public UIAutoTooltipType type;

		public bool isAutoClose;

		public UIToolTipPanelType panelType;

		public UITooltipPanelPositionType posType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITutorialAutoAlarmData()
		{
			throw null;
		}
	}
}
