using System;
using System.Collections;
using System.Runtime.CompilerServices;
using CustomInvitation.SteamAPI;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class MainManager : MonoBehaviour
	{
		private static MainManager _instance;

		[Header("Main")]
		public CustomResourceManager customResourceManager;

		public StageInfoPreviewer stagePreviewer;

		public EnemyUnitInfoPreviewer enemyUnitPreviewer;

		public DropBookPreviewer dropBookPreviewer;

		public KeyPagePreviewer enemyKeyPagePreviewer;

		public KeyPagePreviewer librarianKeyPagePreviewer;

		public CombatPagePreviewer combatPagePreviewer;

		public PassiveInfoPreviewer passivePreviewer;

		[Header("Popup")]
		public WorkshopItemPopupSetter _workshopItemSetter;

		[Header("Top Buttons")]
		[SerializeField]
		private Image _blockImage;

		[SerializeField]
		private Button _newButton;

		[SerializeField]
		private Button _localLoadButton;

		[SerializeField]
		private Button _localSaveButton;

		[SerializeField]
		private Button _uploadButton;

		[SerializeField]
		private Button _editWorkshopItemButton;

		[SerializeField]
		private Button _resourceButton;

		[SerializeField]
		private Button _editStoryButton;

		[SerializeField]
		private Button _logButton;

		[SerializeField]
		private Button _exitProgramButton;

		[Header("Panels")]
		[SerializeField]
		private ResourcePanelManager _resourcePanel;

		[SerializeField]
		private GameObject _languagePanel;

		[SerializeField]
		private Dropdown _dropdownLanguage;

		[SerializeField]
		private Button _languageDoneButton;

		private string _language;

		private SteamAPI.SteamAPI _api;

		private bool _createdOrLoaded;

		public static MainManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetLanguage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetCurrentWorkingPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitMenu()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneLanguageSelection()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitWorkshopInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickNewItem()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickLoadModData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickSaveModData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickUploadingItem()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SaveItem()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenWorkshopItemEditor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenLog()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenStoryEditor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExitProgram()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateNewItem(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadLocalItem(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UploadItem()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator UploadRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitCustomResource()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MainManager()
		{
			throw null;
		}
	}
}
