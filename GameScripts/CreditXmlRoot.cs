using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class CreditXmlRoot
{
	[XmlElement("bigTitle")]
	public List<CreditXmlInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreditXmlRoot()
	{
		throw null;
	}
}
