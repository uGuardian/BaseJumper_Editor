using System;
using UnityEngine;

public class BodyAura_PhilipBurnHead : BodyAura
{
	protected override void Update()
	{
		base.Update();
		if (this._appearance != null)
		{
			int childCount = this._appearance.GetCurrentMotion().customPivot.childCount;
			bool active = true;
			if (childCount > 0)
			{
				active = false;
			}
			foreach (GameObject gameObject in this._objectList)
			{
				gameObject.SetActive(active);
			}
		}
	}
}
