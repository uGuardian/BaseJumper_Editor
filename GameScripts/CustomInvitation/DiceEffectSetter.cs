using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DiceEffectSetter : MonoBehaviour
	{
		public const string NO_EFFECT = "__No Effect__";

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private DiceEffectSummary _effectSummaryRef;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private ToggleListFilter _searchFilter;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private EffectPreview _preEffectPreview;

		[SerializeField]
		private EffectPreview _postEffectPreview;

		private List<DiceEffectSummary> _effectPresetList;

		private DiceEffectSummary _preSelectedEffect;

		private DiceEffectSummary _postSelectedEffect;

		private Action<string> _callback;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActivated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenEffectWindow(string curEffectRes, Action<string> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitUI()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitEffectPresets()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectEffect(DiceEffectSummary effectSummary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneEffectSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelEffectSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Activate(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceEffectSetter()
		{
			throw null;
		}
	}
}
