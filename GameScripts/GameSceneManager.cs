using System;
using System.Runtime.CompilerServices;
using StoryScene;
using UI;
using UI.Title;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
	private static GameSceneManager _instance;

	public UITitleController titleScene;

	public BattleScene battleScene;

	public UIColorManager uiColorManager;

	public StoryRoot storyRoot;

	public GameVideoPlayer video;

	public UIController uIController;

	public UISpriteDataManager uiSpriteDataManager;

	public static GameSceneManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartProcess()
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
	public void ActivateTitleScene(bool anim = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateBattleScene()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenBattleSettingUI()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateStoryScene()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateUIController(bool initUIScene = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateVideo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameSceneManager()
	{
		throw null;
	}
}
