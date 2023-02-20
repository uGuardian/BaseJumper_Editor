using System;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class StorySelectOptionSlot : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private StorySelectOptionPopup panel;

	[Header("Main Text")]
	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private UICustomGraphicObject button;

	[Header("Sub Text")]
	[SerializeField]
	private GameObject subRect;

	[SerializeField]
	private TextMeshProUGUI subText;

	[Header("Effect")]
	[SerializeField]
	private Color RedColor;

	[SerializeField]
	private Color BlueColor;

	[SerializeField]
	private GameObject selectEffect;

	[SerializeField]
	private Image selectGlowEffect;

	[SerializeField]
	private TextMeshProUGUI effectText;

	private StorySelectOptionSlot.DelegateEvent delegateEvent;

	private bool isValid;

	public UICustomSelectable selectable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(string mainText, bool isRed, StorySelectOptionSlot.DelegateEvent del, bool isConditionValid, string conditionText = "")
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnButtonSubmit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnButtonSelect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnButtonDeselect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StorySelectOptionSlot()
	{
		throw null;
	}

	public delegate void DelegateEvent();
}
