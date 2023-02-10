using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPagePassive : MonoBehaviour
	{
		[SerializeField]
		private Color[] _rarityColor;

		[SerializeField]
		private Text _passiveCostText;

		[SerializeField]
		private Text _passiveNameText;

		[SerializeField]
		private Text _passiveDescText;

		[SerializeField]
		private Toggle _toggle;

		private CustomId _id;

		private PresetManager.PassivePreset _passiveData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveInfo(PassiveXmlInfo passiveXmlInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(CustomId id, PresetManager.PassivePreset passivePresetData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomId GetID()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetManager.PassivePreset GetPassiveData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggleEvent(UnityAction<Toggle> action)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsToggleActive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitUI(PresetManager.PassivePreset passiveData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPagePassive()
		{
			throw null;
		}
	}
}
