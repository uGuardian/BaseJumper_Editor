using System;
using System.Runtime.CompilerServices;

namespace UI
{
	public class UIStoryKeyData
	{
		public UIStoryLine StoryLine;

		public int chapter;

		public string workshopId;

		public bool IsWorkshop
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsNormalStory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryKeyData(int chap, UIStoryLine story)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryKeyData(int chap, string workshopID)
		{
			throw null;
		}
	}
}
