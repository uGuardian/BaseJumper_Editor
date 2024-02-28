using System;
using UnityEngine;

public class BattleObjectView : MonoBehaviour
{
	protected BattleObjectModel _baseModel;

	public BattleObjectModel GetBaseModel()
	{
		return this._baseModel;
	}
}
