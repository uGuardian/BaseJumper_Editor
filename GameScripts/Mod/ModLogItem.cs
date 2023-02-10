using System;
using System.Runtime.CompilerServices;

namespace Mod
{
	public class ModLogItem
	{
		public string packageId;

		public string msg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModLogItem(string packageId, string msg)
		{
			throw null;
		}
	}
}
