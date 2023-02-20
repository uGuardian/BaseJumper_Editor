using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;

public class DropBookXmlInfo
{
	[XmlAttribute("ID")]
	public int _id;

	[XmlIgnore]
	public bool isError;

	[XmlIgnore]
	public string workshopID;

	[XmlElement("Text")]
	public int _textId;

	[XmlElement("Name")]
	public string workshopName;

	[XmlElement("TextId")]
	public string _targetText;

	[XmlElement("BookIcon")]
	public string _bookIcon;

	[XmlElement("Chapter")]
	public int chapter;

	[XmlElement("BookValue")]
	public int bookvalue;

	[XmlElement("Episode")]
	public int episode;

	[XmlElement("EquipProb")]
	public float equipProb;

	[XmlElement("DropItemState")]
	public DropItemState itemDropState;

	public BookOption option;

	[XmlElement]
	public int Exp;

	[XmlElement("DropNum")]
	public int DropNum;

	[XmlElement("DropItem")]
	public List<BookDropItemXmlInfo> _DropItemList;

	[XmlIgnore]
	public List<BookDropItemInfo> DropItemList;

	[XmlIgnore]
	public LorId id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public int TextId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public string BookIcon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public Sprite bookIcon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[XmlIgnore]
	public Sprite bookIconGlow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitializeDropItemList(string defaultPid)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DropBookXmlInfo()
	{
		throw null;
	}
}
