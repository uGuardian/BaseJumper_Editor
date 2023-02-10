using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class FormationXmlRoot
{
	[XmlElement("Formation")]
	public List<FormationXmlInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationXmlRoot()
	{
		throw null;
	}
}
