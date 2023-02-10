using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PostProcessing;
using UnityEngine.UI;
using WorkParser;

namespace StoryScene
{
	public class StoryManager : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public List<StoryManager.LocalizedFont> fontList;

		private static StoryManager _instance;

		public List<DialogButtonUI> UIDialogButtons;

		private bool autoClick;

		private float defaultAutoLength;

		[SerializeField]
		private BattleStoryUI _battleStoryUI;

		[SerializeField]
		private StoryRoot _storyRoot;

		[SerializeField]
		private StoryBgmController _bgmController;

		private Coroutine _bgmLoadingCoroutine;

		public AudioSource voice;

		public AudioSource soundEffect;

		public AudioSource txtSoundEffect;

		public AudioSource RevealSoundEffect;

		public Text txtCurPlace;

		public Text txtCurName;

		public Image imgCurNameBg;

		public Text txtCurDesc;

		public Text txtCurDialog;

		public ChapterUI chapterBg;

		public Image imgCurBg;

		public Transform characterPosPivot;

		public GameObject paperEffect;

		public PostProcessingBehaviour postProcessing;

		public Animator bgChangeAnim;

		public Animator tempAnim;

		public List<Sprite> sprListAnimException;

		public GameObject skipRoot;

		public bool blockClick;

		[Range(0.01f, 1f)]
		public float waitTime;

		private float dialogWaitTime;

		[Range(0f, 1f)]
		public float voiceVolume;

		public float effectVolume;

		public float bgmVolume;

		private Chapter chapter;

		private SceneEffect effectDefinition;

		public Dictionary<int, DlgEffect> dlgEffectDic;

		private Dictionary<string, AudioClip> _bgmRes;

		private Dictionary<string, Sprite> _bgImgRes;

		private Dictionary<string, AudioClip> _soundEffectRes;

		public EffectSoundPlayer effectSoundRefObj;

		private Dictionary<string, StoryCharacter> _characterDic;

		private StoryCharacter _curTeller;

		private List<EffectSoundPlayer> _curPlayingEffectSounds;

		private List<EffectSoundPlayer> _curPlayingLoopSounds;

		private bool _isDisplaying;

		public bool IsFadeText;

		public Image dialogIconImg;

		private Queue<Dialog> _dialogQueue;

		private Queue<Place> _placeQueue;

		private Dictionary<string, Sprite> _loadedCustomSprites;

		private Dictionary<string, AudioClip> _loadedCustomAudioClips;

		[SerializeField]
		private Image imgFade;

		[Header("Controller")]
		[SerializeField]
		private UICustomSelectablePanel selectablePanel;

		[SerializeField]
		private List<GameObject> controlGuides;

		[Header("StartBgData")]
		[SerializeField]
		private StoryChapterStartProloguePanel startProloguePanel;

		[Header("popup")]
		[SerializeField]
		private DialogLogManager dialogLogManager;

		[SerializeField]
		private StorySelectOptionPopup storySelectOptionPopup;

		public StoryAnimationController storyFilmAnimationController;

		private bool isVoicePlaying;

		[Header("Monologue")]
		[SerializeField]
		private Image img_DefaultBg;

		[SerializeField]
		private Image img_MonologueBg;

		[SerializeField]
		private Image img_EdgeFrame;

		[SerializeField]
		private Image[] img_monoActiveFrames;

		[SerializeField]
		private RectTransform rect_SkipButton;

		[SerializeField]
		private RectTransform rect_Buttons;

		[SerializeField]
		private RectTransform rect_AutoButton;

		[SerializeField]
		private RectTransform rect_DialogButton;

		[SerializeField]
		private RectTransform[] rect_ButtonContentForChangeDir;

		[SerializeField]
		private TextMeshProUGUI[] txt_buttonstext;

		[SerializeField]
		private RectTransform rect_Textdialog;

		[Header("FastButton")]
		[SerializeField]
		private GameObject _fastButtonRoot;

		[SerializeField]
		private Sprite[] _fastButtonSprites;

		[SerializeField]
		private Image _fastButtonImg;

		[SerializeField]
		private GameObject _fastButtonTooltip;

		private bool _fastToggleOn;

		private bool _fastTogglePointerEnter;

		private bool _fastButtonDown;

		private float _elapsedFast;

		private readonly Vector3 originButtonsPosition;

		private readonly Vector3 monoButtonsPosition;

		private readonly Vector3 originSkipButtonPosition;

		private readonly Vector3 monoSkipButtonPosition;

		private readonly Vector3 origintextdialogPosition;

		private readonly Vector3 monotextdialogPosition;

		private readonly Vector3 origintextdialogsize;

		private readonly Vector3 monotextdialogsize;

		[SerializeField]
		private CamFilterChangeBgController camfilterchangebgcontroller;

		private const string _storyDirectoryPath = "StoryResource/";

		private const string _voicePath = "Voices/";

		private const string _bgmPath = "Bgms/";

		private const string _bgSpritesPath = "BgSprites/";

		private const string _effectSoundsPath = "SoundEffects/";

		private int targetIdx;

		private bool isJustRead;

		private bool OnlyAutoSkip;

		public bool _diagInitializing;

		private int dialogCount;

		private bool _bDoneChangeAnim;

		private GameObject _yanSpecialEffect;

		private GameObject _yanSpecialLoopEffect;

		private GameObject _xiaoSpecialEffect;

		private bool _bYanSpecialEffectPlaying;

		private bool _bXiaoSpecialEffectPlaying;

		private Coroutine _autoClipCoroutine;

		public static StoryManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeFontByLanguage(string language)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowFastButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideFastButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowSkip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideSkip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SkipAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator FadeInRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnControllerSubmit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClickEvent(bool inputed, bool printSpecialEffect = true)
		{
			throw null;
		}

		public bool DiagInitaializing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitDialogs(int startIdx = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeDialog(bool forcely = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeBgSpriteEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckBgChange()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CanAnim(Dialog d)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckBgChangeAnimState(DlgEffect dlgEffect)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeBgAnimForcely()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearResources()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndStory(bool forcely = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneYanSpecialEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneXiaoSpecialEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroySpecialEffects()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyXiaoSpecialEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator DisplayDialog(Dialog dialog)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AutoSkip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator AnimateNameBG()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator AnimateNameText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 GetLastCharPos()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeByMod()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEffectIdChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator WaitDisplay()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeVisual(Dialog d, bool forcely)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayVoice(Dialog d)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator AudioClipOver(float audioLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator SkipAfterSec(float sec)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickAutoButton(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickExitLogPanelButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckForExtraLog(int chapter, int group, int episode, int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopVoice(Dialog d)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetVoicePath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnLoadBgmClip(DlgEffect dlgEffect, AudioClip clip, bool forcely)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadAndPlayBackgroundMusic(DlgEffect dlgEffect, bool forcely)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite LoadBackgroundSprite(string src)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryCharacter LoadCharacterPrefab(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private StoryCharacter CreateStoryCharacterFromSprite(Sprite charSprite)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnVolumeChanged(OptionDataModel option)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectionPopupRevealSound()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetJustRead(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterFastButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitFastButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickFastButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateFastButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReleaseCoroutine(ref Coroutine coroutine)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryManager()
		{
			throw null;
		}

		[Serializable]
		public class LocalizedFont
		{
			public string lang;

			public Font font;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LocalizedFont()
			{
				throw null;
			}
		}
	}
}
