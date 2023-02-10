using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class FinalRewardCardInfo
{
	[XmlAttribute("Num")]
	public int num;

	[XmlText]
	public int id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalRewardCardInfo()
	{
		throw null;
	}
}
