using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class TitleXmlRoot
{
	[XmlElement("Prefix")]
	public TitleListRoot prefixXmlList;

	[XmlElement("Postfix")]
	public TitleListRoot postfixXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TitleXmlRoot()
	{
		throw null;
	}
}
