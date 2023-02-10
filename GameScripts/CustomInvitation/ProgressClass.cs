using System;
using System.Runtime.CompilerServices;

namespace CustomInvitation
{
	public class ProgressClass : IProgress<float>
	{
		private float lastValue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Report(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProgressClass()
		{
			throw null;
		}
	}
}
