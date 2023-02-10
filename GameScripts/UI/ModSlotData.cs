using System;
using System.Runtime.CompilerServices;
using Mod;

namespace UI
{
	public class ModSlotData
	{
		public string ModId;

		public ModContentInfo ModInfo;

		public bool IsActivated;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModSlotData()
		{
			throw null;
		}
	}
}
