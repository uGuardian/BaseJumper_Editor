using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Workshop
{
	public class ClothCustomizeData
	{
		private Sprite _sprite;

		private Sprite _frontSprite;

		public string spritePath;

		public string frontSpritePath;

		public bool hasFrontSprite;

		public bool hasFrontSpriteFile;

		public bool hasSpriteFile;

		public Vector2 headPos;

		public Vector2 pivotPos;

		public float headRotation;

		public bool headEnabled;

		public CharacterMotion.MotionDirection direction;

		public Sprite sprite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Sprite frontSprite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadSprite()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadFrontSprite()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClothCustomizeData()
		{
			throw null;
		}
	}
}
