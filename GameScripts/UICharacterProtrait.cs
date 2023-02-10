using System;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterProtrait : MonoBehaviour
{
	[SerializeField]
	private SkeletonGraphic _weaponGraphic;

	[SerializeField]
	private Image _bodyImg;

	[SerializeField]
	private Image _headImg;

	[SerializeField]
	private Image _faceImg;

	[SerializeField]
	private Image _hairFrontImg;

	[SerializeField]
	private Image _hairBackImg;

	[SerializeField]
	private Image _acceFrontImg;

	[SerializeField]
	private Image _acceBackImg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnitData(UnitDataModel data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICharacterProtrait()
	{
		throw null;
	}
}
