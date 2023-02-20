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
		private void InitMenu()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneLanguageSelection()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitWorkshopInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickNewItem()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickLoadModData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickSaveModData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClickUploadingItem()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SaveItem()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenWorkshopItemEditor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenLog()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenStoryEditor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExitProgram()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateNewItem(string absolutePath)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadLocalItem(string absolutePath)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UploadItem()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator UploadRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitCustomResource()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MainManager()
		{
			throw null;
		}
	}
}
