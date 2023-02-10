using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
	[RequireComponent(typeof(InputField))]
	public class ToggleListFilter : MonoBehaviour
	{
		[SerializeField]
		private InputField _inputField;

		private List<Toggle> _toggleList;

		private Toggle _inactiveToggleWithIsOn;

		private List<Text> _targetTextList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggleList(List<Toggle> toggles)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetTextList(List<Text> texts)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditSearchText(string input)
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
		public ToggleListFilter()
		{
			throw null;
		}
	}
}
