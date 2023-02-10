using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CardRangeSetter : MonoBehaviour
	{
		[SerializeField]
		private ToggleGroupEventHandler _rangeToggleHandler;

		private CardRange _range;

		private const string _RANGE_NEAR = "Near";

		private const string _RANGE_FAR = "Far";

		private const string _RANGE_INSTANT = "Instant";

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRange(CardRange range)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardRange GetRange()
		{
			throw null;
		}

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
		private void ToggleCardRange(Toggle active)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardRangeSetter()
		{
			throw null;
		}
	}
}
