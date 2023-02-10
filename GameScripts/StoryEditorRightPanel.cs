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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitEditPanel(StoryEditor se, int startIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSaveCurEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickAddEffectBtn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickDeleteCurEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickAddCharacter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickEffectPanelConfirm(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeCharacterResName(string resName, Dropdown faces, Dropdown bodies)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCharacterEffect(Character character, Vector3 uiPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteCharacterEffect(Character c, CharacterSummary cs)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleBgm()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBgmValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBackgroundValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCGValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFilterValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBgChangeAnimValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEffectValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharacterValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharAppear(bool isOn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharDisappear(bool isOn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCharEffectValueChanged()
	{
		throw null;
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
