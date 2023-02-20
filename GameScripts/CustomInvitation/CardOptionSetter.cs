using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CardOptionSetter : MonoBehaviour
	{
		[SerializeField]
		private Toggle _toggleExclusive;

		[SerializeField]
		private Toggle _toggleExhaust;

		private bool _exclusive;

		private bool _exhaust;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOptions(List<CardOption> optionList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<CardOption> GetOptions()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleExclusive(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleExhaust(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardOptionSetter()
		{
			throw null;
		}
	}
}
