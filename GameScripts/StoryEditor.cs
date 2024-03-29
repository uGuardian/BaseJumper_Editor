﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WorkParser;

public class StoryEditor : MonoBehaviour
{
	private static StoryEditor _instance;

	[Header("Prefab")]
	[SerializeField]
	private GameObject dlgSummary;

	[SerializeField]
	private GameObject characterSummary;

	private List<GameObject> _defaultCharPrefabList;

	private List<string> _defaultCharSpriteExtraList;

	private List<string> _defaultBgSpriteList;

	private List<string> _defaultBgmList;

	private Dictionary<string, string> charSpriteExternalDict;

	private Dictionary<string, string> bgSpriteExternalDict;

	private Dictionary<string, string> bgmExternalDict;

	private bool _defaultPresetInit;

	[SerializeField]
	private GameObject editorPanel;

	[Header("Left Panel")]
	[SerializeField]
	private Button btnSave;

	[SerializeField]
	private Text curDialogId;

	[SerializeField]
	private Button btnAddEffect;

	[SerializeField]
	private Transform dlgListRoot;

	[SerializeField]
	private ScrollRect dlgScrollRect;

	[SerializeField]
	private RightClickMenuPanel rightClickMenuPanel;

	[Header("Right Panel")]
	[SerializeField]
	private GameObject notDefinedUI;

	[SerializeField]
	private GameObject editPanelUI;

	[SerializeField]
	private Dropdown dropdownBgMusic;

	[SerializeField]
	private Dropdown dropdownBgImage;

	[SerializeField]
	private Dropdown dropdownCgImage;

	[SerializeField]
	private SoundEffectSelector effectSoundToggle;

	[SerializeField]
	private Dropdown dropdownCamFilter;

	[SerializeField]
	private Dropdown dropdownBgchangeAnim;

	[SerializeField]
	private Transform charListRoot;

	public StoryEditorRightPanel rightPanel;

	[Header("Bottom Panel")]
	public StoryEditorBottomPanel bottomPanel;

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

	private Dialog curDiag;

	public int startIdx;

	private List<string> _characterNameList;

	private List<DlgSummary> dlgSummaries;

	private List<CharacterSummary> charSummaries;

	public static StoryEditor Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GameObject> GetCharNewPrefabList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetCharSpriteList()
	{
		throw null;
	}

	public bool IsDiagFocused
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetCharacterNameList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSaveFile()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSaveFileByModdingTool()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickReplay()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickRefresh()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRightClickDialog(DlgSummary target, Vector2 pos)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUpdateDialogEffect(int index, bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDiagFront(int diagId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDiagBack(int diagId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveDiag(int diagId, int targetDiagId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveDiag(int diagId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDiagPlace(int diagId, string placeText)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveDiagPlace(int diagId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Place GetPlace(int diagId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDialog(Dialog diag)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDialogId(int id)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEditPanel()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDefaultPreset()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DlgSummary CreateDlgSummary(Place p, Dialog d)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDiagList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnOpenStory()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateExternalResources(string path)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitRightPanelUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRightPanelValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBottomPanelValueChanged(Dialog dialog)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DivideEpisode(int diagId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StoryEditor()
	{
		throw null;
	}
}
