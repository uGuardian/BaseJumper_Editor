using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleMapEffectManager : SingletonBehavior<BattleMapEffectManager>
{
	[SerializeField]
	private BloodStainBehavior _bloodStainPrefab;

	[SerializeField]
	private Transform _effectRoot;

	private List<GameObject> _createdBloodStainList = new List<GameObject>();

	private List<GameObject> _createdCraterList = new List<GameObject>();

	[SerializeField]
	private List<GameObject> _otherEffectList = new List<GameObject>();

	protected BattleMapEffectManager()
	{
	}

	public void Clear()
	{
		foreach (GameObject obj in this._createdBloodStainList)
		{
			UnityEngine.Object.Destroy(obj);
		}
		this._createdBloodStainList.Clear();
		foreach (GameObject obj2 in this._createdCraterList)
		{
			UnityEngine.Object.Destroy(obj2);
		}
		this._createdCraterList.Clear();
		foreach (GameObject gameObject in this._otherEffectList)
		{
			if (gameObject != null)
			{
				UnityEngine.Object.Destroy(gameObject);
			}
		}
		this._otherEffectList.Clear();
	}

	public void AddEffectToList(GameObject go)
	{
		this._otherEffectList.Add(go);
	}

	public void CreateScratch(float m, Vector3 pos, Vector3 dir, float unitScale)
	{
		if (m <= 0f)
		{
			return;
		}
		int num;
		if (m <= 16f)
		{
			num = 0;
		}
		else if (m <= 30f)
		{
			num = 1;
		}
		else
		{
			num = 2;
		}
		GameObject scratch = SingletonBehavior<BattleSceneRoot>.Instance.currentMapObject.GetScratch(num, this._effectRoot);
		if (scratch != null)
		{
			float num2;
			if (num == 0)
			{
				num2 = (m * 0.333f + 0.666f) * unitScale;
			}
			else if (num == 1)
			{
				num2 = ((m - 16f) * 0.333f + 0.666f) * unitScale;
			}
			else
			{
				num2 = ((m - 30f) * 0.555f + 0.444f) * unitScale;
			}
			num2 = Mathf.Clamp(num2, 1f, 6f);
			Transform transform = scratch.transform;
			transform.gameObject.AddComponent<BattleMapEffectFocus>();
			transform.right = dir;
			transform.position = pos;
			transform.position = pos - transform.right + new Vector3(0f, 0.01f, 0f);
			transform.localScale *= num2;
		}
	}

	public void CreateWallCrater(Vector3 pos, HexagonalMapManager.WallDirection dir)
	{
		pos = SingletonBehavior<HexagonalMapManager>.Instance.ViewToCellWorldPos(pos);
		GameObject wallCrater = SingletonBehavior<BattleSceneRoot>.Instance.currentMapObject.GetWallCrater();
		if (wallCrater != null)
		{
			Transform transform = UnityEngine.Object.Instantiate<GameObject>(wallCrater, this._effectRoot).transform;
			transform.gameObject.AddComponent<BattleMapEffectFocus>();
			transform.localScale *= 1f + UnityEngine.Random.Range(0f, 1f);
			transform.position = pos;
			transform.Rotate(0f, 0f, UnityEngine.Random.Range(0f, 180f));
			if (this._createdCraterList.Count > 30)
			{
				GameObject gameObject = this._createdCraterList[0];
				UnityEngine.Object.Destroy(gameObject);
				this._createdCraterList.Remove(gameObject);
			}
			this._createdCraterList.Add(transform.gameObject);
		}
	}

	public void CreateBloodStainEffect(Vector3 pos, Vector2 dir, float scaleFactor)
	{
		BloodStainBehavior bloodStainBehavior = UnityEngine.Object.Instantiate<BloodStainBehavior>(this._bloodStainPrefab, this._effectRoot);
		bloodStainBehavior.Init(pos, dir, scaleFactor);
		if (this._createdBloodStainList.Count > 30)
		{
			GameObject gameObject = this._createdBloodStainList[0];
			UnityEngine.Object.Destroy(gameObject);
			this._createdBloodStainList.Remove(gameObject);
		}
		this._createdBloodStainList.Add(bloodStainBehavior.gameObject);
	}
}
