using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSummary : MonoBehaviour
{
	private StoryEditorRightPanel _parentPanel;

	[SerializeField]
	private Dropdown dropdownResName;

	[SerializeField]
	private Dropdown dropdownPos;

	[SerializeField]
	private Dropdown dropdownFaces;

	[SerializeField]
	private Dropdown dropdownBodies;

	[SerializeField]
	private Dropdown dropdownEmotions;

	[SerializeField]
	private Button btnPopup;

	[SerializeField]
	private Toggle toggleIsTelling;

	[SerializeField]
	private Toggle _toggleAppear;

	[SerializeField]
	private Toggle _toggleDisappear;

	public Character characterInfo;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleAppear(bool isOn)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleDisappear(bool isOn)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickEditEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickDelete()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSetCharacter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleIsTelling()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedResName()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedFace()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedBody()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedEmotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedPos()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInfo(StoryEditorRightPanel parentPanel, Character cInfo, List<string> nameList, List<string> faceList, List<string> bodyList, List<string> emotionList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChanged()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterSummary()
	{
		throw null;
	}
}
