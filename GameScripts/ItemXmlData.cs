using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class ItemXmlData
{
	[XmlAttribute("ID")]
	public int id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemXmlData()
	{
		throw null;
	}
}
