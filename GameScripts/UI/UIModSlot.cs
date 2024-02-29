using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIModSlot : MonoBehaviour
	{
		[SerializeField]
		private Image _frame;

		[SerializeField]
		private Text _nameText;

		[SerializeField]
		private Toggle _ActivationToggle;

		[SerializeField]
		public UICustomSelectable selectable;

		private ModSlotData _data;

		private UIModPopup panel;

		public ModSlotData Data
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActivated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(UIModPopup popup)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(ModSlotData data)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDeactive()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnToggleValueChanged(bool b)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselect()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmit()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted(bool b)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color c)
		{

		}
	}
}
