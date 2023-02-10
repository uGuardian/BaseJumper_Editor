using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIPopupWindowManager : SingletonBehavior<UIPopupWindowManager>
	{
		public List<UIPopup> popupPanels;

		[SerializeField]
		private GameObject _background;

		public UIEndingCreditPopup endingCreditPopup;

		public UIEndingLogoPopup endingLogoVideoPopup;

		public UIMainOverlayManager mainOverlayTooltipManager;

		public UIMainAutoTooltipManager mainAutoTooltipManager;

		public UIMainTutorialManager mainTutorialMnager;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEndingCredit(bool ingame)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEndingLogoPlayer(bool ingame)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnESC()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AllClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenUI(UIPopupType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseUI(UIPopupType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckOpenedUI(UIPopupType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AllCheckOpen()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPopupWindowManager()
		{
			throw null;
		}
	}
}
