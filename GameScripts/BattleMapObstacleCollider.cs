using System;
using UnityEngine;

public class BattleMapObstacleCollider : MonoBehaviour
{
	public AudioSource audioSrc;

	public SpriteRenderer spr;

	public ParticleSystem ps;

	[SerializeField]
	protected BoxCollider _collider;

	protected bool _bCollision;

	protected float _originColliderSizeZ;

	public virtual void EnableObj(bool b)
	{
		this.ps.GetComponent<ParticleSystemRenderer>().enabled = b;
		this.spr.enabled = b;
		this._collider.enabled = b;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.tag == "BattleUnit")
		{
			this.spr.enabled = false;
			Vector3 normalized = (base.transform.position - other.transform.position).normalized;
			ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime = this.ps.velocityOverLifetime;
			ParticleSystem.MinMaxCurve x = velocityOverLifetime.x;
			x.constantMin = 0f;
			x.constantMin = normalized.x * 5f;
			ParticleSystem.MinMaxCurve z = velocityOverLifetime.z;
			z.constantMin = 0f;
			z.constantMax = normalized.z * 5f;
			velocityOverLifetime.x = x;
			velocityOverLifetime.z = z;
			this.ps.gameObject.SetActive(true);
			this.audioSrc.volume = SingletonBehavior<BattleSoundManager>.Instance.VolumeFX;
			this.audioSrc.Play();
			this.OffCollider();
			this._bCollision = true;
		}
	}

	protected virtual void OffCollider()
	{
		this._collider.enabled = false;
	}

	protected virtual void Awake()
	{
		this._collider = base.GetComponent<BoxCollider>();
		this._originColliderSizeZ = this._collider.size.z;
		this._bCollision = false;
	}

	protected virtual void OnEnable()
	{
		this._bCollision = false;
		this.spr.enabled = true;
		this.ps.Clear();
		this.ps.Stop();
		this.ps.gameObject.SetActive(false);
	}

	protected virtual void OnDisable()
	{
		this._bCollision = false;
		this.spr.enabled = false;
		this.ps.gameObject.SetActive(false);
	}

	protected virtual void FixedUpdate()
	{
		Vector3 size = this._collider.size;
		if (SingletonBehavior<RencounterManager>.Instance != null)
		{
			size.z = (SingletonBehavior<RencounterManager>.Instance.IsRunning ? (this._originColliderSizeZ * 4f) : this._originColliderSizeZ);
			this._collider.size = size;
		}
	}
}
