using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DropBookEditor : MonoBehaviour
	{
		[SerializeField]
		private Image _blockImg;

		[SerializeField]
		private InputField _inputName;

		[SerializeField]
		private Dropdown _dropdownChapter;

		[SerializeField]
		private KeyPageRewardsSetter _keyPageRewardsSetter;

		[SerializeField]
		private CombatPageRewardsSetter _combatPageRewardsSetter;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		private bool _isNewDropBook;

		private Action _callback;

		private DropBookXmlInfo _curDropBook;

		private CardDropTableXmlInfo _curDropCard;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenEditorWindow(DropBookXmlInfo dropBookInfo, CardDropTableXmlInfo dropCardInfo, Action callback, bool isNew)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetData(DropBookXmlInfo dropbookInfo, CardDropTableXmlInfo dropCardInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneDropbookSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckDataValid()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkKeyPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DropbookDone()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelDropbookSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookEditor()
		{
			throw null;
		}
	}
}
