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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISimpleFill()
		{
			throw null;
		}
	}
}
