using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EditorCardSummary : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private DiceCardXmlInfo _info;

	[SerializeField]
	private Text _id;

	[SerializeField]
	private Text _name;

	public DiceCardXmlInfo CardInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCardInfo(DiceCardXmlInfo info)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerClick(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditorCardSummary()
	{
		throw null;
	}
}
