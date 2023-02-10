using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleDiceCard_BehaviourDescUI : MonoBehaviour
{
	[Header("Colors")]
	[SerializeField]
	private Color[] refsColors_FaceColor;

	[Header("Reference")]
	public Image img_detail;

	public TextMeshProUGUI txt_ability;

	public TextMeshProUGUI txt_range;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBehaviourInfo(DiceBehaviour behaviour, LorId cardId, List<DiceBehaviour> behaviourList, bool isHide = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetText(DiceBehaviour behaviour)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCard_BehaviourDescUI()
	{
		throw null;
	}
}
