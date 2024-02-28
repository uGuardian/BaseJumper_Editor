using System;
using UnityEngine;

public class BattleEffectSound : MonoBehaviour
{
	private AudioSource _audioSrc;

	private float length;

	private float elapsed;

	public void Init(AudioClip ac, float volume = 1f, bool loop = false)
	{
		if (Singleton<StageController>.Instance.argaliaFinalMapChanged)
		{
			volume *= 0.5f;
		}
		this._audioSrc.clip = ac;
		this._audioSrc.volume = volume;
		this._audioSrc.Play();
		this._audioSrc.loop = loop;
		this.length = ac.length;
	}

	public bool IsPlaying()
	{
		return !(this._audioSrc == null) && this._audioSrc.isPlaying;
	}

	public void ChangeVolume(float volume)
	{
		this._audioSrc.volume = volume;
	}

	public void Release()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	private void Awake()
	{
		this._audioSrc = base.GetComponent<AudioSource>();
	}

	private void Start()
	{
	}

	private void Update()
	{
		this.elapsed += Time.deltaTime;
		if (this.elapsed > this.length + 1f && !this._audioSrc.loop)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
