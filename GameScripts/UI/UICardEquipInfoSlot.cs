using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICardEquipInfoSlot : MonoBehaviour
	{
		[SerializeField]
		private FaceEditor faceEditor;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private GameObject xbox_root;

		[SerializeField]
		private GameObject portrait_root;

		[SerializeField]
		private Image[] frames;

		[SerializeField]
		private TextMeshProUGUI CardNum;

		private CardOwnResult curInfo;

		private UICardEquipInfoPanel rootPanel;

		[SerializeField]
		private Button button_xbox;

		public UICustomSelectable selectable;

		public GameObject ControllerIcon;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotActive(CardOwnResult info, UICardEquipInfoPanel root)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlotDeactive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorOthers(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickXBox()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardEquipInfoSlot()
		{
			throw null;
		}
	}
}
