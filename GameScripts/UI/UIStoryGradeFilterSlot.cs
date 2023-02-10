using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIStoryGradeFilterSlot : MonoBehaviour
	{
		[SerializeField]
		private UIStoryGradeFilter storyGradeFilter;

		[SerializeField]
		private UICustomSelectableToggle SelectableToggle;

		[SerializeField]
		private Image img_icon;

		[SerializeField]
		private Image img_iconGlow;

		private Grade gradeIdx;

		public Grade Grade
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsOn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetParentSelectable(UICustomSelectable parent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggleOn(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryGradeFilterSlot()
		{
			throw null;
		}
	}
}
