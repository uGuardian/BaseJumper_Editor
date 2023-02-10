using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class SimpleXmlList
{
	[XmlElement("Item")]
	public List<string> items;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SimpleXmlList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SimpleXmlList(IEnumerable<string> data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SimpleXmlList LoadFromResource(string resourcePath)
	{
		throw null;
	}
}
