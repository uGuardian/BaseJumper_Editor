using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class FormationXmlInfo
{
	[XmlAttribute("ID")]
	public int id;

	[XmlElement("Name")]
	public string name;

	[XmlElement("Unlock")]
	public int unlock;

	[XmlElement("Position")]
	public List<FormationPositionXmlData> positionList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormationXmlInfo()
	{
		throw null;
	}
}
