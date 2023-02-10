using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StoryScene;
using UnityEngine;
using UnityEngine.UI;

public class BattleStoryUI : MonoBehaviour
{
	public bool isRunning;

	public Camera storyCamera;

	public GameObject storyUI;

	public StoryManager storyManager;

	public StoryEditor storyEditor;

	public Image philipFilter;

	public AnimationCurve curve;

	private BattleStoryUI.OnEndStoryFunc _onEndStoryFunc;

	private bool _bDelCbAfterEnd;

	private Dictionary<int, Action> _onEventFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPhilipFilter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator r()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenStory(BattleStoryUI.OnEndStoryFunc endFunc, bool nonskip = false, bool blockBattle = true)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEvent(int dialogId, Action func)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallEvent(int dialogId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndStory()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleStoryUI()
	{
		throw null;
	}

	public delegate void OnEndStoryFunc();
}
