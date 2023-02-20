using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PreviewSetterUI : MonoBehaviour
{
	[SerializeField]
	private PreviewDataUI previewPrefab;

	private List<PreviewDataUI> previewDataList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPreviewCard(BattleUnitModel selectedunit, int slotidx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PreviewSetterUI()
	{
		throw null;
	}
}
