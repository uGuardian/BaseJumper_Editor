using System;
using System.Collections;
using System.Runtime.CompilerServices;
using StoryScene;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using WorkParser;

public class CharacterDialogLog : MonoBehaviour
{
	public DialogLogManager dialogLogManager;

	[Header("DialogLog")]
	[SerializeField]
	private GameObject dialogLogRoot;

	[SerializeField]
	private Text NameText;

	[SerializeField]
	private Text DialogText;

	[SerializeField]
	private Image PortraitImage;

	[SerializeField]
	private Image NameFrameImage;

	[SerializeField]
	private Image VoiceDisableImage;

	[SerializeField]
	private Image VoiceAbleImage;

	[SerializeField]
	private Image VoiceImage;

	[SerializeField]
	private Sprite VoiceDefaultSprite;

	[SerializeField]
	private Sprite VoicePlayingSprite;

	[Header("ExtraLog")]
	[SerializeField]
	private GameObject extraLogRoot;

	[SerializeField]
	private Text extraText;

	[SerializeField]
	private Image extraImage;

	[SerializeField]
	private Color RedColor;

	[SerializeField]
	private Color BlueColor;

	[Header("References")]
	public RectTransform rect;

	public Dialog dialog;

	public UICustomSelectable selectable;

	public DialogLogManager panel;

	[HideInInspector]
	public bool isDialog;

	private CharacterDialogLog.VoiceState voiceState;

	private StoryManager _storyManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Dialog _dialog, Font font)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(string text, bool isRed, Font font)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnclickVoiceButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OffVoice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnVoice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator CheckIfVoiceEnd(float voiceLength)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSubmit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCancel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterDialogLog()
	{
		throw null;
	}

	private enum VoiceState
	{
		Disable,
		Default,
		Playing
	}
}
