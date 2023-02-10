using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class ResourceXmlInfo
{
	[XmlElement("ID")]
	public int ID;

	[XmlElement("FileName")]
	public string fileName;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceXmlInfo()
	{
		throw null;
	}
}
