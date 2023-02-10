using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIMenuItem : MonoBehaviour
	{
		[SerializeField]
		private UIControlButtonPanel panel;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Image icon;

		[SerializeField]
		public TextMeshProUGUI text;

		[SerializeField]
		private TextMeshProMaterialSetter setter_text;

		[SerializeField]
		private RefineHsv icon_hsv;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Animator anim_Icon;

		public UICustomSelectable selectable;

		[Header("Inspector Fixed")]
		[SerializeField]
		private UIMainMenuTap _tapState;

		[SerializeField]
		private GameObject ob_TextRoot;

		[Header("Only TheBlueReverberationPrimary")]
		[SerializeField]
		private GameObject ob_LockRoot;

		[SerializeField]
		private Image img_OpenLock;

		[SerializeField]
		private Image img_CloseLock;

		private bool isSelected;

		private bool isDisabled;

		public UIMainMenuTap TapState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsDisabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckLock()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveOrigin(bool on)
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
		public void SetState(UIButtonState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedButton(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetActive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetDeactive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetHide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMenuItem()
		{
			throw null;
		}
	}
}
