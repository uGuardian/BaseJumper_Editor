using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	public class ToggleGroupEventHandler : MonoBehaviour
	{
		public ToggleGroupEventHandler.ToggleEvent onToggleChanged;

		[SerializeField]
		private Toggle[] _toggles;

		private ToggleGroup _toggleGroup;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle[] GetToggles()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggles(Toggle[] toggles)
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
		private void OnToggled(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ToggleGroupEventHandler()
		{
			throw null;
		}

		[Serializable]
		public class ToggleEvent : UnityEvent<Toggle>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ToggleEvent()
			{
				throw null;
			}
		}
	}
}
