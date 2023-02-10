using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class GiftStatEffect
{
	[XmlElement("HP")]
	public int Hp;

	[XmlElement("Break")]
	public int Break;

	[XmlElement("BR")]
	public int BreakRecover;

	[XmlElement("Tune")]
	public int Tune;

	[XmlElement("Amp")]
	public int Amp;

	[XmlIgnore]
	public int Dmg;

	[XmlIgnore]
	public int SlashDmg;

	[XmlIgnore]
	public int PenetrateDmg;

	[XmlIgnore]
	public int HitDmg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftStatEffect()
	{
		throw null;
	}
}
