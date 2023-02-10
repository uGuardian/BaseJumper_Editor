using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

public class OrchestraMap_Movement : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _paperScaleCurve;

	[SerializeField]
	private AnimationCurve _paperAlphaCurve;

	[SerializeField]
	private AnimationCurve _typoAlphaCurve;

	[SerializeField]
	private AnimationCurve _twistCurve;

	[SerializeField]
	private bool _rotateCCW;

	[SerializeField]
	private float _rotateSpeed;

	[SerializeField]
	private SpriteRenderer _typoSprite;

	[SerializeField]
	private SpriteRenderer _musicPaper;

	[SerializeField]
	private AudioClip _soundClip;

	[SerializeField]
	private SoundEffectPlayer _soundInstance;

	private float _bgmVolume;

	private bool _bRotation;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate(BattleUnitModel self)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deactivate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaySound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutSound()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutSoundRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FadeTypo()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeTypoRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FadeMusicPapaer()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeMusicPaperRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScaleMusicPaper()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ScaleMusicPaperRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TwistMusicPaper()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator TwistMusicPaperRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutMusicPaper()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator FadeOutMusicPaperRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OrchestraMap_Movement()
	{
		throw null;
	}
}
