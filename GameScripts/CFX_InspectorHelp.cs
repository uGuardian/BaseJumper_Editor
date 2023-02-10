using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CFX_InspectorHelp : MonoBehaviour
{
	public bool Locked;

	public string Title;

	public string HelpText;

	public int MsgType;

	[ContextMenu("Unlock editing")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Unlock()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CFX_InspectorHelp()
	{
		throw null;
	}
}
