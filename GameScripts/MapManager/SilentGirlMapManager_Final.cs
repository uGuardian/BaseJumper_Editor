using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SilentGirlMapManager_Final : KeterFinalMapManager
{
	[SerializeField]
	private List<GameObject> _mapChangeEffect;

	[SerializeField]
	private AudioClip _mapChangedSound;

	[SerializeField]
	private List<SpriteRenderer> _defaultMapRenderer;

	[SerializeField]
	private List<SpriteRenderer> _finalMapRenderer;

	[SerializeField]
	private List<GameObject> thirdPhaseEyeEffects;

	[SerializeField]
	private GameObject thirdPhaseEyeStartEffects;

	[SerializeField]
	private GameObject _eyeObjectsRoot;

	[SerializeField]
	private List<GameObject> eyeObjectList;

	[Header("2페이즈 죄책감 흐트러짐 연출용")]
	[SerializeField]
	private GameObject _nailRainEffectRes;

	[SerializeField]
	private GameObject _nailDamagedEffectRes;

	[SerializeField]
	private GameObject _redEyeEffectRes;

	[SerializeField]
	private GameObject _redEyeFlashEffectRes;

	[SerializeField]
	private AudioClip _atkSound;

	[SerializeField]
	private AudioClip _fallingSound;

	private GameObject _phaseTwoEyeEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPhaseTwoSpecialEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeletePhaseEyeEffect(bool create)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SpecialRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMapToFinal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateThirdPhaseEffect(bool eye, bool start)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateEyeObject(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenRandomEye()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseAllEyes()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateAngelaDialog()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SetDialogueColors()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SilentGirlMapManager_Final()
	{
		throw null;
	}
}
