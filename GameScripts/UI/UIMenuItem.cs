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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckLock()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveOrigin(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(UIButtonState state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedButton(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetActive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetDeactive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetHide()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMenuItem()
		{
			throw null;
		}
	}
}
