using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPagePassivePresetViewer : MonoBehaviour
	{
		[SerializeField]
		private KeyPagePassive _refPassive;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private Text _curSelectedCountText;

		[SerializeField]
		private ToggleListFilter _filter;

		[SerializeField]
		private Toggle _toggleEquipped;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[Header("Runtime")]
		[SerializeField]
		private List<KeyPagePassive> _passiveList;

		private Action<List<KeyPagePassive>> _callback;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenPassivePreset(List<KeyPagePassive> equippedPassiveList, Action<List<KeyPagePassive>> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPassivePreset()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TogglePassivePreset(Toggle toggle)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DonePassiveSelection()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelPassiveSelection()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewEquippedPassives(bool isOn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPagePassivePresetViewer()
		{
			throw null;
		}
	}
}
