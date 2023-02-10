using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class BookDropItemXmlInfo
{
	[XmlText]
	public int id;

	[XmlAttribute("Pid")]
	public string pid;

	[XmlAttribute("Type")]
	public DropItemType itemType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookDropItemXmlInfo()
	{
		throw null;
	}
}
