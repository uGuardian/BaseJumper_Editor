using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIEquipCardSlot : UIOriginCardSlot
	{
		[Header("Child")]
		[SerializeField]
		private UIEquipCardList listPanel;

		[Header("Inspector reference")]
		[SerializeField]
		private UILibrarianInfoInCardPhase librarianinfo;

		[SerializeField]
		private UIBattleSettingLibrarianInfoPanel settinglibrarianinfo;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEquipedState(bool on)
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
		public override void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipCardSlot()
		{
			throw null;
		}
	}
}
