using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class BookCharacterSkin
{
	[XmlElement]
	public string resName;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookCharacterSkin()
	{
		throw null;
	}
}
