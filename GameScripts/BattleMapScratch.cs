using System;
using UnityEngine;

public class BattleMapScratch : MonoBehaviour
{
	private SpriteRenderer _renderer;

	private float _elapsed;

	private void Awake()
	{
		this._renderer = base.GetComponent<SpriteRenderer>();
		Color color = this._renderer.color;
		color.a = 0f;
		this._renderer.color = color;
	}

	private void Start()
	{
	}

	private void Update()
	{
		if (this._elapsed <= 1f)
		{
			this._elapsed += Time.deltaTime * 5f;
			Color color = this._renderer.color;
			color.a = this._elapsed;
			this._renderer.color = color;
			return;
		}
		this._elapsed = 2f;
	}
}
