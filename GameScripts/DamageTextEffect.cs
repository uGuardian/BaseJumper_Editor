using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamageTextEffect : MonoBehaviour
{
	public Transform rotatePivot;

	public Transform translatePivot;

	public Transform damageNumParent;

	public GameObject[] damageTypeImg;

	public DamageIcon img_RecoverIcon;

	public Image img_resistIcon;

	public Image img_resistIconBg;

	public Image img_resistIconFg;

	public TextMeshProUGUI txt_resist;

	[SerializeField]
	internal DamageNumber[] imgs;

	internal Vector2 direction;

	internal float angle;

	public bool maxEffect;

	public bool isAtk;

	public List<DamageNumber> numberList;

	private float _elapsedTime;

	public float sign;

	public float xScaleFactor;

	public bool startDelay;

	public Canvas canvas;

	private float _waitTime;

	private Vector3 _originLocalScale;

	private Vector3 _translateDir;

	private float addheightscale;

	private float currentorthosize;

	private float _delay;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MaxDiceRoutine()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetScaleByCamSize(float height)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddScaleByheight(float addvalue)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetScale()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DamageTextEffect()
	{
		throw null;
	}
}
