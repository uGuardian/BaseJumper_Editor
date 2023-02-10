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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPassivePreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TogglePassivePreset(Toggle toggle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DonePassiveSelection()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelPassiveSelection()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewEquippedPassives(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPagePassivePresetViewer()
		{
			throw null;
		}
	}
}
