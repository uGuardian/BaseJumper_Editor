using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CharacterSkinListViewer : MonoBehaviour
	{
		[SerializeField]
		protected CharacterSkinSummary _ref;

		[SerializeField]
		protected LayoutGroup _layout;

		[SerializeField]
		protected ToggleGroup _toggleGroup;

		[SerializeField]
		protected List<CharacterSkinSummary> _characterList;

		[SerializeField]
		protected CanvasGroup _canvasGroup;

		[SerializeField]
		protected ToggleListFilter _inputSearchFilter;

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
		public void ClearToggleEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CallToggleEvent(object obj)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void EnableUI(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ClearCharacterList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSkinListViewer()
		{
			throw null;
		}
	}
}
