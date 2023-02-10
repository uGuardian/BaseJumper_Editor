using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FormationPosition
{
	public FormationPositionXmlData _xmlInfo;

	public List<FormationPositionEvent> eventList;

	public int index;

	private Vector3Int _pos;

	public Vector3Int Pos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationPosition(FormationPositionXmlData info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePos(Vector2Int v)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePosToDefault()
	{
		
	}
}
