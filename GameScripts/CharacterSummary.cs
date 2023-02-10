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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleDisappear(bool isOn)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickEditEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickDelete()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSetCharacter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnToggleIsTelling()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedResName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedFace()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedBody()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedEmotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChangedPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInfo(StoryEditorRightPanel parentPanel, Character cInfo, List<string> nameList, List<string> faceList, List<string> bodyList, List<string> emotionList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnValueChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterSummary()
	{
		throw null;
	}
}
