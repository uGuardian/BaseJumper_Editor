using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ActionTotalDamage : MonoBehaviour
{
	public Image[] imgDamageNumbers;

	public Transform layoutRoot;

	private List<Image> numberList;

	private float elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetNumber()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDamageText(int dmg)
	{

	}
}
