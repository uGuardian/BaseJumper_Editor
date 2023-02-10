using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class PosInfoList
{
	[XmlElement("Info")]
	public List<PosInfo> infoList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PosInfoList()
	{
		throw null;
	}
}
