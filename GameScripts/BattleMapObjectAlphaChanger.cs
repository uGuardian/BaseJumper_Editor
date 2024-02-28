using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleMapObjectAlphaChanger : MonoBehaviour
{
	private SpriteRenderer _spriteRenderer;

	private List<Transform> _tList = new List<Transform>();

	private BoxCollider _collider;

	public void SetTransparent(Transform t)
	{
		if (!this._tList.Exists((Transform x) => x == t))
		{
			this._tList.Add(t);
		}
	}

	public void DelUnit(Transform t)
	{
		if (this._tList.Exists((Transform x) => x == t))
		{
			this._tList.Remove(t);
		}
	}

	private void Awake()
	{
		this._spriteRenderer = base.GetComponent<SpriteRenderer>();
		this._collider = base.GetComponent<BoxCollider>();
	}

	private void Update()
	{
		if (this._spriteRenderer.enabled)
		{
			Vector3 min = this._spriteRenderer.bounds.min;
			Vector3 max = this._spriteRenderer.bounds.max;
			if (SingletonBehavior<BattleCamManager>.Instance != null)
			{
				Vector3 vector = SingletonBehavior<BattleCamManager>.Instance.mainCam.ViewportToWorldPoint(min);
				Vector3 vector2 = SingletonBehavior<BattleCamManager>.Instance.mainCam.ViewportToWorldPoint(max);
				Color color = this._spriteRenderer.color;
				foreach (BattleObjectLayer.UnitViewportPosInfo unitViewportPosInfo in BattleObjectLayer.instance.unitViewportList)
				{
					if (unitViewportPosInfo.viewportPos.x > vector.x && unitViewportPosInfo.viewportPos.x < vector2.x && unitViewportPosInfo.viewportPos.y > vector.y && unitViewportPosInfo.viewportPos.y < vector2.y && unitViewportPosInfo.viewportPos.z > vector.z && unitViewportPosInfo.viewportPos.z < vector2.z)
					{
						color.a = 0.5f;
						break;
					}
					color.a = 1f;
				}
				this._spriteRenderer.color = color;
			}
		}
		else if (base.transform.GetChild(0) != null)
		{
			Transform child = base.transform.GetChild(0);
			if (child.GetComponent<SpriteRenderer>() != null)
			{
				SpriteRenderer component = child.GetComponent<SpriteRenderer>();
				if (component != null && component.enabled)
				{
					Vector3 min2 = this._spriteRenderer.bounds.min;
					Vector3 max2 = this._spriteRenderer.bounds.max;
					if (SingletonBehavior<BattleCamManager>.Instance != null)
					{
						Vector3 vector3 = SingletonBehavior<BattleCamManager>.Instance.mainCam.ViewportToWorldPoint(min2);
						Vector3 vector4 = SingletonBehavior<BattleCamManager>.Instance.mainCam.ViewportToWorldPoint(max2);
						Color color2 = this._spriteRenderer.color;
						foreach (BattleObjectLayer.UnitViewportPosInfo unitViewportPosInfo2 in BattleObjectLayer.instance.unitViewportList)
						{
							if (unitViewportPosInfo2.viewportPos.x > vector3.x && unitViewportPosInfo2.viewportPos.x < vector4.x && unitViewportPosInfo2.viewportPos.y > vector3.y && unitViewportPosInfo2.viewportPos.y < vector4.y && unitViewportPosInfo2.viewportPos.z > vector3.z && unitViewportPosInfo2.viewportPos.z < vector4.z)
							{
								color2.a = 0.5f;
								break;
							}
							color2.a = 1f;
						}
						this._spriteRenderer.color = color2;
					}
				}
			}
		}
		if (BattleObjectManager.instance != null)
		{
			List<BattleUnitModel> aliveList = BattleObjectManager.instance.GetAliveList(false);
			bool flag = false;
			for (int i = 0; i < aliveList.Count; i++)
			{
				Vector3 position = base.transform.position;
				Vector3 position2 = aliveList[i].view.transform.position;
				if (position2.z > position.z - 0.1f && Vector3.Distance(position, position2) < 10f)
				{
					flag = true;
					break;
				}
			}
			Color color3 = this._spriteRenderer.color;
			if (flag && base.gameObject.layer != LayerMask.NameToLayer("Focus_UnitAction"))
			{
				color3.a = 0.5f;
			}
			else
			{
				color3.a = 1f;
			}
			this._spriteRenderer.color = color3;
		}
	}
}
