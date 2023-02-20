using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StoryFilmAnimation : MonoBehaviour
{
	[SerializeField]
	private List<Sprite> sprites;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private Image mainImage;

	private int idx;

	private StoryFilmAnimation.DelegateEvent delegateEvent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayAnim(StoryFilmAnimation.DelegateEvent del)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFilmAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndChangeFilmAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEndFilmAnim()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActive(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StoryFilmAnimation()
	{
		throw null;
	}

	public delegate void DelegateEvent();
}
