using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	[RequireComponent(typeof(CanvasGroup))]
	public class UIPanel : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
	{
		public UIPanelType panelType;

		public GameObject ActiveControl;

		private Animator _revelAnimator;

		public UITransitionHandler TransitionHandler;

		private CanvasGroup _group;

		public static UIController Controller
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Animator RevealAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public CanvasGroup cg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual bool IsActivated
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnSetSephirah(SephirahType targetSephirah)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ToolTipTarget GetToolTipID()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetToolTipText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveCg(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPanel()
		{
			throw null;
		}
	}
}
