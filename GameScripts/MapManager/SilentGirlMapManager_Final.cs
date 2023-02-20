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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeletePhaseEyeEffect(bool create)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator SpecialRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMapToFinal()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateThirdPhaseEffect(bool eye, bool start)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ActivateEyeObject(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenRandomEye()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseAllEyes()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateAngelaDialog()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SetDialogueColors()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SilentGirlMapManager_Final()
	{
		throw null;
	}
}
