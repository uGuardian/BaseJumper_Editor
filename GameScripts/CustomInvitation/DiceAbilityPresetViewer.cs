using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DiceAbilityPresetViewer : MonoBehaviour
	{
		[SerializeField]
		protected VerticalLayoutGroup _layout;

		[SerializeField]
		protected ToggleGroupEventHandler _toggleGroupHandler;

		[SerializeField]
		protected DiceAbility _abilityUI;

		[SerializeField]
		protected ToggleListFilter _toggleFilter;

		[SerializeField]
		private Dropdown _dataResourceTagDropdown;

		[SerializeField]
		protected Button _doneButton;

		[SerializeField]
		protected Button _cancelButton;

		[Header("Runtime")]
		[SerializeField]
		protected List<DiceAbility> _abilityList;

		protected DiceAbilityPresetViewer.ConfirmAbility _confirmEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string GetAbilityDesc(string abilityID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OpenAbilityPresetViewer(DiceAbilityPresetViewer.ConfirmAbility confirmEvent, string appliedAbilityName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InitAbilityPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Dictionary<string, string> GetAbilityPresetDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Dictionary<string, string> GetCautionAbilityPresetDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual List<string> GetAbilityListFromAssembly()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void DoneAbilitySetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CancelAbilitySetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDataResourceTagChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceAbilityPresetViewer()
		{
			throw null;
		}

		public struct AbilityData
		{
			public string id;

			public string descText;
		}

		public delegate void ConfirmAbility(string id, string text);
	}
}
