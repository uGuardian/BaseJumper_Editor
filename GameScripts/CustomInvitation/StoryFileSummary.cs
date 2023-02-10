using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class StoryFileSummary : MonoBehaviour
	{
		[SerializeField]
		private Text _storyFileText;

		[SerializeField]
		private Toggle _toggle;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStoryName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(string storyFileName, Action<StoryFileSummary> toggleEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryFileSummary()
		{
			throw null;
		}
	}
}
