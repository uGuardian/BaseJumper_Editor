using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class CreditXmlPerson
{
	[XmlAttribute("id")]
	public string name;

	[XmlElement("content")]
	public string content;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreditXmlPerson()
	{
		throw null;
	}
}
