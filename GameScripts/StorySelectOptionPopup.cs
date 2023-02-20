using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StoryScene;
using UI;
using UnityEngine;

public class StorySelectOptionPopup : MonoBehaviour
{
	public List<StorySelectOptionSlot> selectOptionSlots;

	public StoryManager manager;

	private string key_blacksilencekill;

	private string key_blacksilenceforgive;

	private string key_blacksilenceforgive_condition;

	private string key_angelakill;

	private string key_angelaforgive;

	private string key_angelaforgive_condition;

	[HideInInspector]
	public bool waitForSelect;

	public UICustomSelectable dummySelectable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Open()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator WaitForSelect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Close()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(StoryBranch branch, bool isjustread)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StorySelectOptionPopup()
	{
		throw null;
	}
}
