﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class PassiveXmlRoot
	{
		[XmlElement("Passive")]
		public List<PassiveXmlInfo> list;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveXmlRoot()
		{
			throw null;
		}
	}
}
