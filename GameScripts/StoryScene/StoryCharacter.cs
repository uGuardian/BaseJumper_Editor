using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StoryScene
{
	public class StoryCharacter : MonoBehaviour
	{
		private SpriteRenderer curFace;

		private SpriteRenderer curBody;

		private List<SpriteRenderer> renderList;

		private List<SpriteRenderer> alwaysRenderList;

		private List<SpriteRenderer> bodyRenderList;

		private List<SpriteRenderer> faceRenderList;

		private List<string> faceNameList;

		private List<string> bodyNameList;

		private float scale;

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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFace(string faceName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBody(string bodyName)
		{
			throw null;
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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CompleteEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> GetFaceNameList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> GetBodyNameList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
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
		private void SetOnlyAlpha(SpriteRenderer r, float a)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetOnlyColor(SpriteRenderer r, Color dc)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ApplyAll(StoryCharacter.CharacterApplier applier)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpriteRenderer GetCurFace()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpriteRenderer GetCurBody()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryCharacter()
		{
			throw null;
		}

		public delegate void CharacterApplier(SpriteRenderer r);
	}
}
