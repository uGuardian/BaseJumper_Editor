using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageDialogSetter : MonoBehaviour
	{
		[SerializeField]
		private RectTransform[] _viewContents;

		[SerializeField]
		private Button[] _addButtons;

		[SerializeField]
		private KeyPageDialog _dialogPrefab;

		[SerializeField]
		private Button _doneButton;

		private Dictionary<DialogType, List<KeyPageDialog>> _dialogItemDict;

		private Dictionary<DialogType, List<string>> _dialogData;

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
		public void OpenDialogPreset(Dictionary<DialogType, List<string>> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearItems()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneDialogSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<DialogType, List<string>> GetDialogList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEmpty()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEditDialog(KeyPageDialog dialogItem, string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteDialog(KeyPageDialog dialogItem)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickAddDialog(DialogType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddDialog(DialogType type, string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageDialogSetter()
		{
			throw null;
		}
	}
}
