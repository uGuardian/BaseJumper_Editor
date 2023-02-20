using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISephirahSelectionButton : MonoBehaviour
	{
		public SephirahType Sephirah;

		[SerializeField]
		private Image sephirahImage;

		[SerializeField]
		private Animator anim;

		public bool isHighlighted;

		[SerializeField]
		private CanvasGroup cg;

		public UICustomSelectable selectable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitAndActivate(SephirahType _sephirahType)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealHighlight()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideHighlight()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlight()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLock()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickButton(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingPanel GetSettingPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISephirahSelectionButton()
		{
			throw null;
		}
	}
}
