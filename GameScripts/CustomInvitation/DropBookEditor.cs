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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetData(DropBookXmlInfo dropbookInfo, CardDropTableXmlInfo dropCardInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneDropbookSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckDataValid()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkKeyPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkCombatPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DropbookDone()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelDropbookSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookEditor()
		{
			throw null;
		}
	}
}
