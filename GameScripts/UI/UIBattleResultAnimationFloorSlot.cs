using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleResultAnimationFloorSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private Image[] img_Frames;

		[Header("Floor")]
		[SerializeField]
		private UIFloorTitlePanel floorTitlePanel;

		[SerializeField]
		private Image[] img_UpperFloorbutton;

		[SerializeField]
		private Image[] img_LowerFloorButton;

		private SephirahType currentsep;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(SephirahType sep, SephirahType prevsep, SephirahType nextsep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBgFloorColor(SephirahType currentsephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpperFloorButton(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLowerFloorButton(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleResultAnimationFloorSlot()
		{
			throw null;
		}
	}
}
