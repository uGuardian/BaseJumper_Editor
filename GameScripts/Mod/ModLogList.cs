using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mod
{
	public class ModLogList
	{
		private List<ModLogItem> _logList;

		public List<ModLogItem> LogList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddLog(string packageId, Exception e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddLog(string packageId, string msg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModLogList()
		{
			throw null;
		}
	}
}
