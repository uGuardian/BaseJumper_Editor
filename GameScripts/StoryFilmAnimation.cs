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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeFilmAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndChangeFilmAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEndFilmAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActive(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StoryFilmAnimation()
	{
		throw null;
	}

	public delegate void DelegateEvent();
}
