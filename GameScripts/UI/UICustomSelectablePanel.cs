﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UI
{
	[ExecuteAlways]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class UICustomSelectablePanel : UICustomSelectable
	{
		[HideInInspector]
		public UIPhase UIPhaseType;

		[HideInInspector]
		public int UIPanelOrder;

		[Header("Panel")]
		public UICustomSelectablePanel Panel_L;

		public UICustomSelectablePanel Panel_R;

		public PanelPosition panelPosition;

		public UnityEvent PanelChangeEvent;

		[SerializeField]
		public UnityEvent SelectPanelEvent;

		[SerializeField]
		public UnityEvent DeselectPanelEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectablePanel FindPanel_L()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectablePanel FindPanel_R()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSelect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeselect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnXEvent(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnYEvent(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselectPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectablePanel()
		{
			throw null;
		}
	}
}
