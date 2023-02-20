using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageEditor : MonoBehaviour
	{
		[SerializeField]
		private InputField _inputName;

		[SerializeField]
		private Dropdown _dropdownChapter;

		[SerializeField]
		private Dropdown _dropdownRarity;

		[SerializeField]
		private InputField _inputHp;

		[SerializeField]
		private InputField _inputBp;

		[SerializeField]
		private InputField _inputSpeedMin;

		[SerializeField]
		private InputField _inputSpeedMax;

		[SerializeField]
		private InputField _inputLightStart;

		[SerializeField]
		private InputField _inputLightMax;

		[SerializeField]
		private Dropdown _dropdownHpResistSlash;

		[SerializeField]
		private Dropdown _dropdownHpResistPenetrate;

		[SerializeField]
		private Dropdown _dropdownHpResistHit;

		[SerializeField]
		private Dropdown _dropdownBpResistSlash;

		[SerializeField]
		private Dropdown _dropdownBpResistPenetrate;

		[SerializeField]
		private Dropdown _dropdownBpResistHit;

		[SerializeField]
		private KeyPageDialogSetter _dialogSetter;

		[SerializeField]
		private KeyPageStorySetter _storySetter;

		[SerializeField]
		private KeyPagePassiveSetter _passiveSetter;

		[SerializeField]
		private KeyPageEnemyDeckSetter _enemyDeckSetter;

		[SerializeField]
		private KeyPageCharacterSkinPopupSetter _characterSkinSetter;

		[SerializeField]
		private Button _buttonSkinSetting;

		[SerializeField]
		private RawImage _CharacterSkinpreviewImage;

		[SerializeField]
		private Text _skinNameText;

		[SerializeField]
		private Toggle _randomFaceToggle;

		[SerializeField]
		private Texture2D _defaultTexture;

		[SerializeField]
		private KeyPageSoundSetter _soundSetter;

		[SerializeField]
		private Button _buttonSoundSetting;

		[SerializeField]
		private Button _buttonDialogSetting;

		[SerializeField]
		private Button _buttonStorySetting;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Image _imageBlocked;

		[SerializeField]
		private List<GameObject> _popupObjList;

		private const int _MIN_STAT = 1;

		private const int _MAX_STAT = 999;

		private const int _MIN_SPEED = 1;

		private const int _MAX_SPEED = 15;

		private const int _MAX_MAX_LIGHT = 9;

		private const int _MIN_MAX_LIGHT = 0;

		private const int _MAX_START_LIGHT = 9;

		private const int _MIN_START_LIGHT = 0;

		private Action _callback;

		private bool _isNewKeyPage;

		private BookXmlInfo _curKeyPage;

		private bool _isEditingEnemyKeyPage;

		private string _skinName;

		private string _skinType;

		private List<BookSoundInfo> _soundList;

		private Dictionary<DialogType, List<string>> _dialogData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenEditorWindow(bool isEnemyKeyPage, BookXmlInfo keyPageInfo, Action callback, bool isNew)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetData(BookXmlInfo bookInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditHp(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditBp(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditSpeedMin(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditSpeedMax(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditLightStart(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditLightMax(string s)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenSkinSetterPopup()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSkinPreviewTex(Texture previewTex, string skinName, string skinType)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenDialogSetterPopup()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenStorySetterPopup()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenSoundSetterPopup()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetCharacterSoundInfo(List<BookSoundInfo> list)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneKeyPageSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckDataValid()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkDialog()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkDeck()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkStory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void KeyPageDone()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelKeyPageSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private AtkResist GetResistByDropdownIdx(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetDropdownIdxByResist(AtkResist resist)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Rarity GetRarityByDropdownIdx(int dropdownIdx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetDropdownIdxByRarity(Rarity rarity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageEditor()
		{
			throw null;
		}
	}
}
