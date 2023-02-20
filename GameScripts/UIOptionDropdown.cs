using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIOptionDropdown : MonoBehaviour
{
	public Color colorNormal;

	public Color colorHighlight;

	public Color colorDisalbed;

	public List<Graphic> colorTargets;

	public List<Graphic> colorTargetsExtern;

	public TextMeshProMaterialSetter tmpSetter;

	public Image openLine;

	public RectTransform autoFitterSrc;

	public List<RectTransform> autoFitterDsts;

	[SerializeField]
	private Image img_SelectableHighlightedFrame;

	private bool selected;

	private bool enter;

	[HideInInspector]
	public bool isDisabled;

	private TMP_Dropdown dropdown;

	private bool _highlighted;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDeSelect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDisabled(bool on)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHighlight(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIOptionDropdown()
	{
		throw null;
	}
}
