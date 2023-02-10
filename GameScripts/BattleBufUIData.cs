using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleBufUIData
{
	public bool destroyed;

	public bool hide;

	public int stack;

	public Sprite bufIcon;

	public string bufActivatedNameWithStack;

	public string bufActivatedText;

	public Type bufClassType;

	public string addDescStateText;

	public BufPositiveType bufPositiveType;

	public BattleUnitBuf buf;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleBufUIData()
	{
		throw null;
	}
}
