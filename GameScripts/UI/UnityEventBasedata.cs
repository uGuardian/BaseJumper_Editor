using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UI
{
	[Serializable]
	public class UnityEventBasedata : UnityEvent<BaseEventData>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnityEventBasedata()
		{
			throw null;
		}
	}
}
