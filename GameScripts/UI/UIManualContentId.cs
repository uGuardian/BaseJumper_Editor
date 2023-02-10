using System;
using System.Runtime.CompilerServices;

namespace UI
{
	[Serializable]
	public struct UIManualContentId
	{
		public int titleid;

		public int subtitleid;

		public int subsubtitleid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualContentId(int titleid, int subtitleid, int subsubtitleid)
		{
			throw null;
		}
	}
}
