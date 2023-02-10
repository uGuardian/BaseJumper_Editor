using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class GiftXmlInfo : ItemXmlData
{
	[XmlElement("Name")]
	public string Name;

	[XmlElement("Resource")]
	public string Resource;

	[XmlElement("Position")]
	public GiftPosition Position;

	[XmlElement("NoAppear")]
	public bool NoAppear;

	[XmlElement("Stat")]
	public GiftStatEffect Stat;

	[XmlElement("Passive")]
	public List<int> ScriptList;

	[XmlElement("Count")]
	public int Count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftXmlInfo()
	{
		throw null;
	}
}
