using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class AttackEffectPathInfoRoot
{
	[XmlElement("Info")]
	public List<AttackEffectPathXmlInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AttackEffectPathInfoRoot()
	{
		throw null;
	}
}
