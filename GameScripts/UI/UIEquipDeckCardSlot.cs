using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UIEquipDeckCardSlot : UIOriginCardSlot
	{
		[Space(10f)]
		[Header("----Child---")]
		[SerializeField]
		private UIEquipDeckCardList listPanel;

		[Header("Empty")]
		[SerializeField]
		protected CanvasGroup cg_LeftPanel;

		[SerializeField]
		public CanvasGroup cg_EmptyFrameRoot;

		private bool isEmpty;

		public bool IsEmpty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(DiceCardItemModel cardmodel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEmpty()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCgLeftPanel(bool on)
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
		public UIEquipDeckCardSlot()
		{
			throw null;
		}
	}
}
