using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class StageXmlRoot
{
	[XmlElement("Stage")]
	public List<StageClassInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageXmlRoot()
	{
		throw null;
	}
}
