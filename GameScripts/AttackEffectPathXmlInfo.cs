using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class AttackEffectPathXmlInfo
{
	[XmlElement("Name")]
	public string name;

	[XmlElement("FilePath")]
	public string filepath;
}
