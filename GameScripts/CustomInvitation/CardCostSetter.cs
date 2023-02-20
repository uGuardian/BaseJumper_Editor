using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CardCostSetter : MonoBehaviour
	{
		[SerializeField]
		private Slider _costSlider;

		[SerializeField]
		private InputField _costInput;

		private const int _MIN_COST = 0;

		private const int _MAX_COST = 9;

		private int _cost;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCost(int cost)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCost()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveCostSlider(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnterCostInput(string input)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardCostSetter()
		{
			throw null;
		}
	}
}
