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
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDeSelect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDisabled(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHighlight(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIOptionDropdown()
	{
		throw null;
	}
}
