using System;
using System.Runtime.CompilerServices;
using LOR_XML;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UICustomizeScriptSlot : UICustomizeSlot
	{
		[HideInInspector]
		public DialogType scriptType;

		[HideInInspector]
		public BattleDialog battleDialog;

		[HideInInspector]
		public DialogData dialogData;

		public RectTransform rect;

		private UICustomizeScriptPanel parent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(DialogType type, BattleDialog bd, UICustomizeScriptPanel panel)
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
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeScriptSlot()
		{
			throw null;
		}
	}
}
