using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIOptionWindow : UIPopup
	{
		public GameObject root;

		public GameObject pcOnlyPanel;

		public UIOptionSoundBar allSound;

		public UIOptionSoundBar bgmSound;

		public UIOptionSoundBar effectSound;

		public UIOptionSoundBar voiceSound;

		[SerializeField]
		private Selectable[] selectables_soundbar;

		public TMP_Dropdown languageDropdown;

		public TMP_Dropdown resolutionDropdown;

		public TMP_Dropdown displayDropdown;

		public TMP_Dropdown texQualityDropdown;

		[SerializeField]
		private Selectable[] selectables_dropdown;

		public UIOptionDropdown languageButtonEffect;

		private List<GameResolution> _resolutions;

		private OptionDataModel _modifyOption;

		[Header("Controller")]
		[SerializeField]
		private List<GameObject> ControllerGuides;

		public UICustomSelectablePanel selectablePanel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitSoundBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitLanguageDropdown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitResolutionDropdown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitDisplayDropdown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitTexQualityDropdown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateOptionData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyAndClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetSound()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractableLanguage(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSelectablePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator SelectFirstSelectable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOptionWindow()
		{
			throw null;
		}
	}
}
