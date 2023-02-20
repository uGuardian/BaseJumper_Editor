using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CreatureDlgManagerUI : SingletonBehavior<CreatureDlgManagerUI>
{
	public CreatureDlgEffectUI prefab;

	public Canvas canvas;

	private List<CreatureDlgEffectUI> _effectList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(bool enable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CreatureDlgEffectUI> SetDlgs(List<string> strList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureDlgEffectUI SetDlg(string str, CreatureDlgEffectUI.UpdateVertexInfoEvent e = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureDlgEffectUI SetDlg(string str, Color txtColor, CreatureDlgEffectUI.UpdateVertexInfoEvent e = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyDlg(CreatureDlgEffectUI e)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureDlgManagerUI()
	{
		throw null;
	}
}
