using System;
using System.Runtime.CompilerServices;

namespace GameSave
{
	public class SaveErrorLog
	{
		public SaveErrorType logType;

		public LorId id;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveErrorLog()
		{
			throw null;
		}
	}
}
