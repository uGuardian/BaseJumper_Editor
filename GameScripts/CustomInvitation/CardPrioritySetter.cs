﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CardPrioritySetter : MonoBehaviour
	{
		[SerializeField]
		private InputField _priorityInput;

		private const int _MAX_PRIORITY = 500;

		private const int _MIN_PRIORITY = 0;

		private int _priority;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPriority(int priority)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetPriority()
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
		private void EditPriority(string input)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardPrioritySetter()
		{
			throw null;
		}
	}
}
