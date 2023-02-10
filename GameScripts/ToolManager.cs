using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
// using SimpleFileBrowser;
using SteamAPI;
using UnityEngine;
using UnityEngine.UI;

public class ToolManager : MonoBehaviour
{
	private static ToolManager _instace;

	private const string _pathtext = "Path of file will be presented here";

	private const string _logtext = "log will be presented here";

	[Header("Main Window:Mod Info")]
	public Text Title;

	public Text Description;

	public Text Tag;

	public Text ContentPath;

	public Text PreviewFile;

	public InputField TitleField;

	public InputField DescField;

	public InputField TagField;

	public Button ContentPathField;

	public Button PreviewFileField;

	[Header("Panel Control")]
	public GameObject MainPanel;

	public GameObject FacePanel;

	public GameObject ClothPanel;

	public GameObject StagePanel;

	public GameObject CardPanel;

	public GameObject PublishPanel;

	public Button MainButton;

	public Button FaceButton;

	public Button ClothButton;

	public Button StageButton;

	public Button CardButton;

	public Button PublishButton;

	[Header("Publish")]
	public Button Publish;

	public Text Pub_Result;

	private ModInfo _modInfo;

	private ItemData _curData;

	private SteamAPI.SteamAPI _api;

	private PanelType _currentPanelType;

	private CustomizeItemType _customType;

	private bool isDone;

	public static ToolManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public ModInfo ModInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public PanelType CurrentPanelType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public CustomizeItemType CustomType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnApplicationQuit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeEmptyData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickUploadWithXml()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UploadAsync()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator UploadCoroutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoneUpload()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator OnDone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSetCustomType(int type)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickLoadXml()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoadXml(string xml)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task OnClickUploadAsync(ItemData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSaveXml()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSaveXml(string path)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoadItemData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSetTitle(string text)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSetDesc(string text)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSetTag(string tag)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickContentPathField()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoadContentFolder(string path)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickPreviewField()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoadPreviewFolder(string path)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPanel(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckValidate()
	{
		throw null;
	}

	/*
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LoadFileWindow(FileBrowser.OnSuccess success, bool folder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveFileWindow(FileBrowser.OnSuccess success, bool folder)
	{
		throw null;
	}
	*/

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolManager()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ToolManager()
	{
		throw null;
	}
}
