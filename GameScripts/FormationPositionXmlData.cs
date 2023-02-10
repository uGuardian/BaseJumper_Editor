using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class FormationPositionXmlData
{
	[XmlElement("Name")]
	public string name;

	[XmlElement("Vector")]
	public XmlVector2 vector;

	[XmlElement("Event")]
	public List<FormationPositionEventXmlData> eventList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationPositionXmlData()
	{
		throw null;
	}
}
