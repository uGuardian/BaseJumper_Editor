using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPagePassiveSetter : MonoBehaviour
	{
		[SerializeField]
		private KeyPagePassive _refPassive;

		[SerializeField]
		private Button _editButton;

		[SerializeField]
		private Button _deleteButton;

		[SerializeField]
		private KeyPagePassivePresetViewer _passivePresetViewer;

		[SerializeField]
		private LayoutGroup _passiveListLayout;

		[SerializeField]
		private ToggleGroup _passiveToggleGroup;

		[SerializeField]
		private Text _curEquippedCountText;

		[SerializeField]
		private Button _moveUpButton;

		[SerializeField]
		private Button _moveDownButton;

		[SerializeField]
		private Image _editingBlockImage;

		[Header("Runtime")]
		[SerializeField]
		private List<KeyPagePassive> _equippedPassiveList;

		private KeyPagePassive _curSelectedEquippedPassive;

		public const int PASSIVE_EQUIP_LIMIT = 9;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<CustomId> GetEquippedPassives()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveData(List<BookPassiveXmlInfo> passiveList)
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
		private void EditPassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeletePassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleEquippedPassive(Toggle toggle)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneEditingPassive(List<KeyPagePassive> selectedList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveUpPassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveDownPassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPagePassiveSetter()
		{
			throw null;
		}
	}
}
