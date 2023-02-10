using System;
using System.Runtime.CompilerServices;

namespace CustomInvitation
{
	public class ValueInfo
	{
		private bool _isError;

		private string _log;

		public bool IsError
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string log
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueInfo(bool isError, string logMessage)
		{
			throw null;
		}
	}
}
