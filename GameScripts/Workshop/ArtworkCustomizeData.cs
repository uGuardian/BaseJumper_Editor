using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Workshop
{
	public class ArtworkCustomizeData
	{
		private Sprite _sprite;

		public string spritePath;

		public string name;

		public Sprite sprite
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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArtworkCustomizeData()
		{
			throw null;
		}
	}
}
