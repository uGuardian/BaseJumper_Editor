using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace LOR_Input
{
	public class LOR_InputModule : PointerInputModule
	{
		private float m_PrevActionTime;

		private Vector2 m_LastMoveVector;

		private int m_ConsecutiveMoveCount;

		private Vector2 m_LastMousePosition;

		private Vector2 m_MousePosition;

		private GameObject m_CurrentFocusedGameObject;

		private PointerEventData m_InputPointerEvent;

		[SerializeField]
		private string m_HorizontalAxis;

		[SerializeField]
		private string m_VerticalAxis;

		private string m_HorizontalDPadAxis;

		private string m_VerticalDPadAxis;

		[SerializeField]
		private string m_SubmitButton;

		[SerializeField]
		private string m_CancelButton;

		[SerializeField]
		private float m_InputActionsPerSecond;

		[SerializeField]
		private float m_RepeatDelay;

		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		private bool m_ForceModuleActive;

		private string m_YButton;

		private AxisEventData m_AxisEventData_dpad;

		private AxisEventData m_AxisEventData_bumper;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected LOR_InputModule()
		{
			throw null;
		}

		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public LOR_InputModule.InputMode inputMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice
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

		public bool forceModuleActive
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

		public float inputActionsPerSecond
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

		public float repeatDelay
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

		public string horizontalAxis
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

		public string verticalAxis
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

		public string submitButton
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

		public string cancelButton
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
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateModule()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsModuleSupported()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ShouldActivateModule()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ActivateModule()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DeactivateModule()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Process()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ProcessTouchEvents()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool SendSubmitEventToSelectedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector2 GetRawMoveVector()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector2 GetRawMoveVector_DPad()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool SendMoveEventToSelectedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessMouseEvent()
		{
			
		}

		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool ForceAutoSelect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessMouseEvent(int id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool SendUpdateEventToSelectedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GameObject GetCurrentFocusedGameObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual AxisEventData GetAxisEventData_dpad(float x, float y, float moveDeadZone)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual AxisEventData GetAxisEventData_bumper(float x, float y, float moveDeadZone)
		{
			throw null;
		}

		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			Mouse,
			Buttons
		}
	}
}
