using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StoryEditorCharEffectPanel : MonoBehaviour
{
	[Header("Character Effect Popup")]
	[SerializeField]
	private GameObject popupPanel;

	[SerializeField]
	private Toggle tgActiveEffect;

	[SerializeField]
	private Slider sliderActiveRatio;

	[SerializeField]
	private InputField inputActiveRatio;

	[SerializeField]
	private Dropdown dropdownActiveEffect;

	[SerializeField]
	private Toggle tgDeactiveEffect;

	[SerializeField]
	private Slider sliderDeactiveRatio;

	[SerializeField]
	private InputField inputDeactiveRatio;

	[SerializeField]
	private Dropdown dropdownDeactiveEffect;

	private StoryEditorRightPanel _rightPanel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(StoryEditorRightPanel rightPanel)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StoryEditorCharEffectPanel()
	{
		throw null;
	}
}
