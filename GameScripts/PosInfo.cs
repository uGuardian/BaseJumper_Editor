using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class PosInfo
{
	[XmlElement("Name")]
	public string name;

	[XmlElement("Height")]
	public int height;

	[XmlElement("XError")]
	public float xError;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PosInfo()
	{
		throw null;
	}
}
