using System;
using System.Collections;
using UnityEngine;

public class BattleMapEffectFocus : MonoBehaviour
{
	private int _defaultLayer;

	public void DestroyEffect()
	{
		base.StartCoroutine(this.LayerRoutine());
	}

	private void Awake()
	{
		this._defaultLayer = base.gameObject.layer;
		int layer = LayerMask.NameToLayer("UI_WORLD");
		base.gameObject.layer = layer;
	}

	private void Start()
	{
		base.StartCoroutine(this.LayerRoutine());
	}

	private IEnumerator LayerRoutine()
	{
		yield return new WaitUntil(() => !SingletonBehavior<RencounterManager>.Instance.IsRunning);
		base.gameObject.layer = this._defaultLayer;
		yield break;
	}
}
