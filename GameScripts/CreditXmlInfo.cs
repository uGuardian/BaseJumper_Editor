using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class CreditXmlInfo
{
	[XmlAttribute("id")]
	public string id;

	[XmlElement("title")]
	public List<CreditXmlTitle> titlelist;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreditXmlInfo()
	{
		throw null;
	}
}
