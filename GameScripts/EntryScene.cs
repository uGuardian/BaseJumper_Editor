using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

public class EntryScene : MonoBehaviour
{
	private bool _loaded;

	private OptionDataModel _option;

	private LatestDataModel _latestData;

	private bool _nowLoading;

	public GameObject target;

	public LogoPlayer logoPlayer;

	[Header("Panels")]
	public GameObject targetCanvas;

	public GameObject Loading_Main;

	[Header("Popups")]
	public UIModPopup modPopup;

	public UIModLogViewer modLogViewer;

	[Header("Loading")]
	public TextMeshProUGUI txt_loading;

	public Image LoadingBar;

	public float LoadingBarMaxSize;

	private AsyncOperation async;

	public Image CGImage;

	private const string _storyDirectoryPath = "StoryResource/";

	private const string _bgSpritesPath = "BgSprites/";

	[Header("Deliberation")]
	[SerializeField]
	private UIAnimationEventHandler deliberationAnimHandler;

	[SerializeField]
	private GameObject ob_deliberationAlarmKr;

	[SerializeField]
	private UIAnimationEventHandler loadingFadeAnimHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickEn()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickKR()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickJP()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickCN()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickTRCN()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPlayEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCompleteInitializePlatform_xboxlive(bool success)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckModError()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GotoTitleOrSelectLanguge()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator Retry()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayLogo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GotoTitle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoToTitle_Controller()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartLoading()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartMoveSceneCoroutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndDeliberationAlarmInAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator AutoActiveDeliberation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MoveScene()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator LoadingProgress()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCG()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EntryScene()
	{
		throw null;
	}
}
