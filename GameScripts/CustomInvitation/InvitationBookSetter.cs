using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class InvitationBookSetter : MonoBehaviour
	{
		[SerializeField]
		private Dropdown _dropdownBookCount;

		[SerializeField]
		private ToggleGroupEventHandler _recipeToggleHandler;

		[SerializeField]
		private Dropdown _dropdownBookValue;

		[SerializeField]
		private FixedBookSetter _fixedBookSetter;

		private const string _TYPE_VALUE = "Value";

		private const string _TYPE_FIXED = "Fixed";

		private int _bookCount;

		private string _combine;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeBookCount(int dropdownIdx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleRecipeType(Toggle active)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InvitationBookSetter()
		{
			throw null;
		}
	}
}
