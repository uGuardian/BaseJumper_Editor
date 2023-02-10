using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class FormationPositionEventXmlData
{
	[XmlElement("Desc")]
	public string desc;

	[XmlElement("Speech")]
	public string speech;

	[XmlElement("Script")]
	public string script;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationPositionEventXmlData()
	{
		throw null;
	}
}
