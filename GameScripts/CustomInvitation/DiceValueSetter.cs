﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DiceValueSetter : MonoBehaviour
	{
		[SerializeField]
		private Slider _minValueSlider;

		[SerializeField]
		private InputField _minValueInput;

		[SerializeField]
		private Slider _maxValueSlider;

		[SerializeField]
		private InputField _maxValueInput;

		private const int _MIN_LIMIT = 1;

		private const int _MAX_LIMIT = 99;

		private int _minValue;

		private int _maxValue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMinValue(int minValue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetMinValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMaxValue(int maxValue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetMaxValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveMinSlider(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveMaxSlider(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnterMinInput(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnterMaxInput(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceValueSetter()
		{
			throw null;
		}
	}
}
