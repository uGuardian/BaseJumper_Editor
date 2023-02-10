using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class TitleXmlInfo
{
	[XmlAttribute("ID")]
	public int ID;

	[XmlAttribute("LocalizeID")]
	public string LocalizeID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TitleXmlInfo()
	{
		throw null;
	}
}
