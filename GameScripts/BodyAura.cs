using System;
using System.Collections.Generic;
using UnityEngine;

public class BodyAura : MonoBehaviour
{
	[SerializeField]
	protected List<GameObject> _objectList;

	[SerializeField]
	protected CharacterAppearance _appearance;

	protected virtual void Update()
	{
		if (this._appearance != null)
		{
			foreach (GameObject gameObject in this._objectList)
			{
				string layerName = this._appearance.GetLayerName();
				gameObject.layer = LayerMask.NameToLayer(layerName);
			}
		}
	}

	public void SetAppearance(BattleUnitModel target)
	{
		this._appearance = target.view.charAppearance;
	}

	public void SetAppearance(CharacterAppearance appearance)
	{
		this._appearance = appearance;
	}
}
