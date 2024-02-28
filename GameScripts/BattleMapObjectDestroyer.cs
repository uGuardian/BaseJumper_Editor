using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleMapObjectDestroyer : MonoBehaviour
{
	private SpriteRenderer _spriteRenderer;

	[SerializeField]
	private List<BoxCollider> _pieceColliderList;

	public void OnTriggerEnter(Collider other)
	{
		this.CheckCollision(other.tag);
	}

	public void OnCollisionEnter(Collision collision)
	{
		this.CheckCollision(collision.gameObject.tag);
	}

	private void CheckCollision(string tag)
	{
		if (tag == "BattleUnit")
		{
			this._spriteRenderer.enabled = false;
			foreach (BoxCollider boxCollider in this._pieceColliderList)
			{
				boxCollider.enabled = true;
				Rigidbody component = boxCollider.GetComponent<Rigidbody>();
				boxCollider.GetComponent<SpriteRenderer>().enabled = true;
				if (component != null)
				{
					component.AddForce(new Vector3(UnityEngine.Random.Range(-3f, 3f), 3f, UnityEngine.Random.Range(-1f, 1f)));
					component.useGravity = true;
				}
			}
			base.GetComponent<Collider>().enabled = false;
		}
	}

	private void Awake()
	{
		this._spriteRenderer = base.GetComponent<SpriteRenderer>();
		this._pieceColliderList = new List<BoxCollider>();
		foreach (BoxCollider boxCollider in base.transform.GetComponentsInChildren<BoxCollider>())
		{
			if (boxCollider != base.GetComponent<BoxCollider>())
			{
				this._pieceColliderList.Add(boxCollider.GetComponent<BoxCollider>());
				boxCollider.gameObject.AddComponent<Rigidbody>().useGravity = false;
				boxCollider.GetComponent<SpriteRenderer>().enabled = false;
			}
		}
	}
}
