using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	[Serializable]
	public class UITutorialPhase
	{
		public List<UITutorialAutoAlarmData> alarmlist;

		public Sprite spr_bg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITutorialPhase()
		{
			throw null;
		}
	}
}
