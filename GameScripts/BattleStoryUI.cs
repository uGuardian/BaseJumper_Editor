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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPhilipFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator r()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenStory(BattleStoryUI.OnEndStoryFunc endFunc, bool nonskip = false, bool blockBattle = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEvent(int dialogId, Action func)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallEvent(int dialogId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleStoryUI()
	{
		throw null;
	}

	public delegate void OnEndStoryFunc();
}
