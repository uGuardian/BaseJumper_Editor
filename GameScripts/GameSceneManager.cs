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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartProcess()
	{
		
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
	public void ActivateTitleScene(bool anim = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateBattleScene()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenBattleSettingUI()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateStoryScene()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateUIController(bool initUIScene = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateVideo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameSceneManager()
	{
		throw null;
	}
}
