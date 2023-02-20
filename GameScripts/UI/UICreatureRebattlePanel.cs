using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICreatureRebattlePanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private List<UICreatureRebattleSephirahSlot> slotlist;

		[Header("Controller")]
		public UICustomSelectablePanel selectablePanel;

		[HideInInspector]
		public int availableFloorCount;

		private int row;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICreatureRebattlePanel()
		{
			throw null;
		}
	}
}
