using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UITutorialAutoAlarmTemplate : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private List<UITutorialPhase> tutorialPhases;

		[SerializeField]
		private Image img_bg;

		[SerializeField]
		private UICustomSelectable selectable;

		[HideInInspector]
		public int currentPhaseCounter;

		private UITutorialAutoAlarmTemplate.OnEndTutorial _onendfunc;

		private UITutorialAutoAlarmTemplate.OnPhaseTutorial _phasestartfunc;

		private Camera cam;

		private int currentCheckOffTooltipCount;

		private int currentTooltipNumberByPhase;

		private UICustomSelectable prevselectable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Open(UITutorialAutoAlarmTemplate.OnEndTutorial endfunc = null, Camera targetcam = null, UITutorialAutoAlarmTemplate.OnPhaseTutorial phasestartfunc = null, bool notselectalbe = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close(bool init = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerClickForTutorial()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartTutorialPhase(UITutorialPhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffTutorialHighlightObjects()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OffCheckTooltip()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITutorialAutoAlarmTemplate()
		{
			throw null;
		}

		public delegate void OnEndTutorial();

		public delegate void OnPhaseTutorial(int phase);
	}
}
