using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIMainAutoTooltipManager : SingletonBehavior<UIMainAutoTooltipManager>
	{
		[Header("Reference")]
		[SerializeField]
		private List<UIAutoTooltipSlot> tooltipPoolingList;

		[Header("Prefab")]
		[SerializeField]
		public Canvas tooltipCanvas;

		public GameObject highlightFramePrefab;

		[HideInInspector]
		public int currentPoolingIdx;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenTooltip(UIAutoTooltipType type, RectTransform targetRect, bool isAutoClose = false, Camera cam = null, UIToolTipPanelType paneltype = UIToolTipPanelType.Normal, UITooltipPanelPositionType postype = UITooltipPanelPositionType.None, bool isoverclose = false, UITutorialAutoAlarmTemplate template = null)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseTooltip(UIAutoTooltipType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AllCloseTooltip()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainAutoTooltipManager()
		{
			throw null;
		}
	}
}
