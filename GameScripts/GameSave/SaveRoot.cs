using System;
using System.Runtime.CompilerServices;

namespace GameSave
{
	public class SaveRoot
	{
		public int ver;

		public SaveData data;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveRoot()
		{
			throw null;
		}
	}
}
