using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Readme : ScriptableObject
{
	public Texture2D icon;

	public string title;

	public Readme.Section[] sections;

	public bool loadedLayout;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Readme()
	{
		throw null;
	}

	[Serializable]
	public class Section
	{
		public string heading;

		public string text;

		public string linkText;

		public string url;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Section()
		{
			throw null;
		}
	}
}
