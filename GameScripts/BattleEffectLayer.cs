using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleEffectLayer : MonoBehaviour
{
	private static BattleEffectLayer _instance;

	private List<TimeScalableEffect> _effectList;

	private float _globalEffectTimeScale = 1f;

	public static BattleEffectLayer instance
	{
		get
		{
			return BattleEffectLayer._instance;
		}
	}

	private void Awake()
	{
		BattleEffectLayer._instance = this;
		this._effectList = new List<TimeScalableEffect>();
	}

	private void Start()
	{
	}

	public void OnFixedUpdate(float deltaTime)
	{
		List<TimeScalableEffect> list = new List<TimeScalableEffect>();
		foreach (TimeScalableEffect timeScalableEffect in this._effectList)
		{
			timeScalableEffect.OnFixedUpdate(deltaTime);
			if (timeScalableEffect.IsFinished())
			{
				list.Add(timeScalableEffect);
			}
		}
		foreach (TimeScalableEffect timeScalableEffect2 in list)
		{
			this._effectList.Remove(timeScalableEffect2);
			UnityEngine.Object.Destroy(timeScalableEffect2.gameObject);
		}
	}

	public void SetTimeScale(float timeScale)
	{
		this._globalEffectTimeScale = timeScale;
		foreach (TimeScalableEffect timeScalableEffect in this._effectList)
		{
			timeScalableEffect.SetTimeScale(timeScale);
		}
	}
}
