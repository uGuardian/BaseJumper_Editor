﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Title
{
	public class UITitleController : MonoBehaviour
	{
		private const int _actionMin = 0;

		private const int _actionMax = 3;

		private static UITitleController _controller;

		[Header("LibraryTitle")]
		[Header("RuinTitle")]
		[SerializeField]
		private GameObject library_Root;

		public GameObject ActiveController;

		public GameObject[] exitButtons;

		public UITitleButtonSlot[] TitleButtons;

		public Vector3[] hsvColors;

		public AudioSource titleBgm;

		[SerializeField]
		private Animator revealAnim;

		[Header("RuinTitle")]
		[SerializeField]
		private GameObject ruin_Root;

		[SerializeField]
		private Animator ruin_revealAnim;

		public UITitleButtonSlot_Ruin[] Ruin_TitleButtons;

		[SerializeField]
		private Animator ruin_selectedButtonTextAnim;

		[SerializeField]
		private TextMeshProUGUI ruin_selectedButtonText;

		[Header("External Components")]
		[SerializeField]
		private GameObject _gamerProfileRoot;

		[SerializeField]
		private Text _gamerTag;

		private int _nextIndex;

		private TitleActionType _currentSelectedActionType;

		private bool isRuinTitle;

		public bool isStartBlockButton;

		public static UITitleController Controller
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int CurrentIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public TitleActionType CurrentSelectedActionType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsRuinTitle
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
		public void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckRuinTitle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckSaveDataExists()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckAction()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectButton(TitleActionType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselectButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSelectedButton(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickActionButton(TitleActionType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TextReload()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NewGame()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Continue()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExitGame()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Setting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Credit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator BlockButtonStateProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeGamerTag()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITitleController()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UITitleController()
		{
			throw null;
		}
	}
}
