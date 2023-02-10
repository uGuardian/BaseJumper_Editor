using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StoryScene
{
	public class Character : MonoBehaviour
	{
		public string belongTo;

		public SpriteRenderer body;

		public SpriteRenderer curFace;

		public List<Sprite> imgList;

		public List<SpriteRenderer> faceRenderList;

		private Dictionary<CharacterPos, Vector3> _refPosDic;

		private CharacterPos _posEnum;

		private bool _appearResult;

		private bool _isTelling;

		public CharacterPos Pos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public string Face
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool IsTelling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate(bool active, CharacterActivate mode, float delay)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CompleteEffect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator AnimInOut(bool activate, float delay)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator FadeInOut(bool activate, float delay)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator Vibe(float delay, float duration = 0.5f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ColorVibe(Color originColor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Character()
		{
			throw null;
		}
	}
}
