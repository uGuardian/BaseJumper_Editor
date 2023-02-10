using System;
using System.Runtime.CompilerServices;

namespace UI
{
	public struct testStoryData
	{
		public StoryState state;

		public int id;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public testStoryData(StoryState state, int id)
		{
			throw null;
		}
	}
}
