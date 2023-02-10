using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EnemyUnitClassRoot
{
	[XmlElement("Enemy")]
	public List<EnemyUnitClassInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyUnitClassRoot()
	{
		throw null;
	}
}
