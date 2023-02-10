using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DlgSummary : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public StoryEditor editor;

	[SerializeField]
	private Text _id;

	[SerializeField]
	private Text _model;

	[SerializeField]
	private Text _place;

	[SerializeField]
	private Text _teller;

	[SerializeField]
	private Text _dialog;

	[SerializeField]
	private Image img;

	[SerializeField]
	private Toggle toggle;

	private int idNum;

	private Color color1;

	private Color color2;

	public bool effectDefined
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	public int dlgId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool toggleOn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerClick(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetId(int id)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTexts(int id, string model, string teller, string dialog, StoryEditor se)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPlace(string text)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DlgSummary()
	{
		throw null;
	}
}
