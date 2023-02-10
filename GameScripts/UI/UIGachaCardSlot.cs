using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIGachaCardSlot : UIOriginCardSlot
	{
		[HideInInspector]
		public int index;

		[Header("Number Frame")]
		[SerializeField]
		private GameObject ob_numberFrame;

		[SerializeField]
		private TextMeshProUGUI txt_Number;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(DiceCardItemModel cardmodel, int Idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataForBattleResult(DiceCardItemModel cardmodel, int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveNumberFrame(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshNumbersData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGachaCardSlot()
		{
			throw null;
		}
	}
}
