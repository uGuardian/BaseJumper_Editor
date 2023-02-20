using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	[ExecuteInEditMode]
	public class UIDividedFillRect : MonoBehaviour
	{
		[Header("Rect Information")]
		public Image FillRect;

		public List<Image> FilledRectList;

		public Color EnabledColor;

		public Color DisabledColor;

		[Range(0f, 1f)]
		public float Value;

		private int _fillRectCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private float _fillRectUnitValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private Image _lastImage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SizeUpdate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDividedFillRect()
		{
			throw null;
		}
	}
}
