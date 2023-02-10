using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpriteCustomizeData
{
	public Sprite sprite;

	public Sprite frontSprite;

	public Vector2 headPos;

	public bool headSaved;

	public Vector2 pivotPos;

	public bool pivotSaved;

	public bool fileSaved;

	public float rotation;

	public HeadDirection dir;

	public bool headEnabled;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpriteCustomizeData()
	{
		throw null;
	}
}
