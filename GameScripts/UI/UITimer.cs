using System;
using System.Runtime.CompilerServices;

namespace UI
{
	public class UITimer
	{
		public UITimer.OnEndEvent EndEvent;

		private bool _isStarted;

		private bool _scaledTime;

		private float _elap;

		private float _defaultMax;

		private float _max;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITimer(float time, bool scaledTime = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(float time)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			
		}

		public delegate void OnEndEvent();
	}
}
