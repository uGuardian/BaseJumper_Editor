using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class PassiveScriptPresetViewer : MonoBehaviour
	{
		[SerializeField]
		protected PassiveScript _scriptUI;

		[SerializeField]
		protected VerticalLayoutGroup _layout;

		[SerializeField]
		protected ToggleGroupEventHandler _toggleGroupHandler;

		[SerializeField]
		protected ToggleListFilter _toggleFilter;

		[SerializeField]
		protected Button _doneButton;

		[SerializeField]
		protected Button _cancelButton;

		[Header("Runtime")]
		[SerializeField]
		protected List<PassiveScript> _scriptList;

		protected PassiveScriptPresetViewer.ConfirmScript _confirmEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenPassiveScriptPresetViewer(PassiveScriptPresetViewer.ConfirmScript confirmScript, string appliedScriptName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitAbilityPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<string> GetPassiveScriptPresetFromAssembly()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneScriptSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CancelAbilitySetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveScriptPresetViewer()
		{
			throw null;
		}

		public delegate void ConfirmScript(string name);
	}
}
