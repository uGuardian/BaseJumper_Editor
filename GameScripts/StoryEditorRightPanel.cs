using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;
using UnityEngine;
using UnityEngine.UI;

public class StoryEditorRightPanel : MonoBehaviour
{
	[Header("Prefab")]
	[SerializeField]
	private GameObject characterSummary;

	[Header("Right Panel")]
	[SerializeField]
	private GameObject notDefinedUI;

	[SerializeField]
	private GameObject editPanelUI;

	[SerializeField]
	private Dropdown dropdownBgMusic;

	[SerializeField]
	private Toggle toggleBgOn;

	[SerializeField]
	private Toggle toggleBgFadeIn;

	[SerializeField]
	private Toggle toggleBgOff;

	[SerializeField]
	private Toggle toggleBgFadeOut;

	[SerializeField]
	private Dropdown dropdownBgImage;

	[SerializeField]
	private Dropdown dropdownCgImage;

	[SerializeField]
	private Dropdown dropdownBGChange;

	[SerializeField]
	private Dropdown dropdownCamFilter;

	[SerializeField]
	private Transform charListRoot;

	[Header("Character Effect Popup")]
	public StoryEditorCharEffectPanel charEffectPanel;

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

	[Header("Effect Sounds Popup")]
	public SoundEffectPanel soundEffectPanel;

	private List<CharacterSummary> charSummaries;

	private int _startIdx;

	private StoryEditor _editor;

	private Character curSelectedCharacter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitEditPanel(StoryEditor se, int startIdx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSaveCurEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickAddEffectBtn()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickDeleteCurEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickAddCharacter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickEffectPanelConfirm(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCharacterResName(string resName, Dropdown faces, Dropdown bodies)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCharacterEffect(Character character, Vector3 uiPos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteCharacterEffect(Character c, CharacterSummary cs)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleBgm()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBgmValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBackgroundValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCGValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFilterValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBgChangeAnimValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEffectValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharacterValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharAppear(bool isOn)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharDisappear(bool isOn)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharEffectValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetFaceNameListFromPrefab(GameObject p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> GetBodyNameListFromPrefab(GameObject p)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StoryEditorRightPanel()
	{
		throw null;
	}
}
