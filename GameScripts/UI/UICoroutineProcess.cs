using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICoroutineProcess : MonoBehaviour
	{
		[Header("Parent Param")]
		public bool isOn;

		[HideInInspector]
		public bool isRunning;

		public float startDelayCount;

		public float repeatDelayCount;

		public float speed;

		[HideInInspector]
		public Coroutine process;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void StartProcess()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICoroutineProcess()
		{
			throw null;
		}
	}
}
