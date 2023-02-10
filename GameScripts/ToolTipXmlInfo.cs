using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class ToolTipXmlInfo
{
	[XmlAttribute("ID")]
	public ToolTipTarget ID;

	[XmlAttribute("LocalizeID")]
	public string LocalizeID;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolTipXmlInfo()
	{
		throw null;
	}
}
