﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class AbnormalityFlavorTextEffect : MonoBehaviour
{
	[SerializeField]
	private EmotionPassiveCardUI cardUI;

	public float AngleMultiplier;

	public float SpeedMultiplier;

	public float CurveScale;

	private TMP_Text m_TextComponent;

	private bool hasTextChanged;

	private Coroutine _routine;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Release()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ON_TEXT_CHANGED(UnityEngine.Object obj)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator AnimateVertexColors()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AbnormalityFlavorTextEffect()
	{
		throw null;
	}

	private struct VertexAnim
	{
		public float angleRange;

		public float angle;

		public float speed;
	}
}
