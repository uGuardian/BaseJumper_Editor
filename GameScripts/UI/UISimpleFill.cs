using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[RequireComponent(typeof(Image))]
	[ExecuteInEditMode]
	public class UISimpleFill : MonoBehaviour
	{
		private Image Fill;

		public bool enable_x;

		public bool enable_y;

		public float maxSize_x;

		public float maxSize_y;

		[Range(0f, 1f)]
		public float value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISimpleFill()
		{
			throw null;
		}
	}
}
