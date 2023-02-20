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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProgressClass()
		{
			throw null;
		}
	}
}
