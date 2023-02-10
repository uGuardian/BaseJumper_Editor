using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EmotionCardXmlInfo
{
	[XmlAttribute("ID")]
	public int id;

	[XmlElement]
	public string Name;

	[XmlElement("Artwork")]
	public string _artwork;

	[XmlElement]
	public MentalState State;

	[XmlElement]
	public EmotionTargetType TargetType;

	[XmlElement]
	public int Level;

	[XmlElement("EmotionLevel")]
	public int EmotionLevel;

	[XmlElement("EmotionRate")]
	public int EmotionRate;

	[XmlElement]
	public bool Locked;

	[XmlElement]
	public SephirahType Sephirah;

	[XmlElement("Script")]
	public List<string> Script;

	[XmlIgnore]
	public string Artwork
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public List<string> Desc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardXmlInfo()
	{
		throw null;
	}
}
