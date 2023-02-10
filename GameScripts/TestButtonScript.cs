using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestButtonScript : MonoBehaviour
{
	public int num;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickTestButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEnterTestButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnExitTestButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestButtonScript()
	{
		throw null;
	}
}
