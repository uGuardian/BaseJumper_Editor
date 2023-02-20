using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CustomInvitation
{
	public class LorCharacterRenderCamera : MonoBehaviour
	{
		private static LorCharacterRenderCamera _instance;

		[SerializeField]
		private Camera _cam;

		[SerializeField]
		private RenderTexture _targetTexture;

		[SerializeField]
		private SpriteRenderer _bgSprite;

		private List<GameObject> _createdList;

		private GameObject _previousObj;

		public static LorCharacterRenderCamera instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeBgColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture RenderCharacter(GameObject go)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture SetSdCharacter(string lorSkinName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LorCharacterRenderCamera()
		{
			throw null;
		}
	}
}
