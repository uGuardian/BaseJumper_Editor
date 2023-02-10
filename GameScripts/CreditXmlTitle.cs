using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class CreditXmlTitle
{
	[XmlAttribute("id")]
	public string id;

	[XmlElement("desc")]
	public List<CreditXmlPerson> personlist;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreditXmlTitle()
	{
		throw null;
	}
}
