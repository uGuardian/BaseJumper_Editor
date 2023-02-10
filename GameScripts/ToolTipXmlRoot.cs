using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class ToolTipXmlRoot
{
	[XmlElement("ToolTip")]
	public List<ToolTipXmlInfo> toolTipXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolTipXmlRoot()
	{
		throw null;
	}
}
