using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public struct NumbersData
{
	public NumbersData.NumbersImageData firstNumbers;

	public NumbersData.NumbersImageData secondNumbers;

	public NumbersData.NumbersImageData thirdNumbers;

	public NumbersData.NumbersImageData FourthNumbers;

	public bool bgUpdated;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnable(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetValueHundredLeft(int amount, Sprite[] sp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBg()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOneValue(int amount, Sprite[] sp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetContentColor(Color c)
	{
		throw null;
	}

	[Serializable]
	public struct NumbersImageData
	{
		public Image content;

		public Image linearDodge;

		public Image Bg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnable(bool b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNumber(bool on, int number, Sprite[] sp)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetContentColor(Color c)
		{
			throw null;
		}
	}
}
