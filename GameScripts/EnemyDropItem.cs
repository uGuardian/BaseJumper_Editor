using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EnemyDropItem
{
	[XmlText]
	public int bookId;

	[XmlAttribute("Prob")]
	public float prob;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyDropItem()
	{
		throw null;
	}
}
