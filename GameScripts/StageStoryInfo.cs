using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class StageStoryInfo
{
	[XmlAttribute("Condition")]
	public StageStoryCond cond;

	[XmlText]
	public string story;

	[XmlIgnore]
	public string packageId;

	[XmlIgnore]
	public bool valid;

	[XmlIgnore]
	public int chapter;

	[XmlIgnore]
	public int group;

	[XmlIgnore]
	public int episode;

	[XmlIgnore]
	public bool IsMod
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageStoryInfo()
	{
		throw null;
	}
}
