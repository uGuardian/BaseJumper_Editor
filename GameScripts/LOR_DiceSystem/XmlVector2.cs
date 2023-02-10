﻿using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class XmlVector2
	{
		[XmlAttribute("x")]
		public int x;

		[XmlAttribute("y")]
		public int y;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlVector2()
		{
			throw null;
		}
	}
}
