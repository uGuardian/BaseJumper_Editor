﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class LorCharacterListViewer : MonoBehaviour
	{
		[SerializeField]
		private CharacterSkinSummary _ref;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private ToggleGroup _toggleGroup;

		[SerializeField]
		private List<CharacterSkinSummary> _characterList;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private ToggleListFilter _inputSearchFilter;

		private event Action<object> _toggleEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToggleEvent(Action<object> method)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableUI(bool enable)
		{
			
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
		private void ToggleLorCharacterSummary(string name)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LorCharacterListViewer()
		{
			throw null;
		}
	}
}
