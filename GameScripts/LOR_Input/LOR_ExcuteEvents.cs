using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace LOR_Input
{
	public class LOR_ExcuteEvents
	{
		private static readonly LOR_ExcuteEvents.EventFunction<IButtonYHandler> s_ButtonYHandler;

		private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool;

		private static readonly List<Transform> s_InternalTransformList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Execute(IButtonYHandler handler, BaseEventData eventData)
		{
			
		}

		public static LOR_ExcuteEvents.EventFunction<IButtonYHandler> buttonYHandler
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Execute<T>(GameObject target, BaseEventData eventData, LOR_ExcuteEvents.EventFunction<T> functor) where T : IEventSystemHandler
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, LOR_ExcuteEvents.EventFunction<T> callbackFunction) where T : IEventSystemHandler
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool ShouldSendToComponent<T>(Component component) where T : IEventSystemHandler
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) where T : IEventSystemHandler
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CanHandleEvent<T>(GameObject go) where T : IEventSystemHandler
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LOR_ExcuteEvents()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LOR_ExcuteEvents()
		{
			throw null;
		}

		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);
	}
}
