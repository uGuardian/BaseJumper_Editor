﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class PassiveDescRoot
	{
		[XmlElement("PassiveDesc")]
		public List<PassiveDesc> descList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveDescRoot()
		{
			throw null;
		}
	}
}
