using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class IntListRoot
{
	[XmlElement("i")]
	public List<int> intList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntListRoot()
	{
		throw null;
	}
}
