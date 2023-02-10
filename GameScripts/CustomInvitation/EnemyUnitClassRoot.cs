using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class EnemyUnitClassRoot
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("Enemy")]
		public List<EnemyUnitClassInfo> list;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyUnitClassRoot()
		{
			throw null;
		}
	}
}
