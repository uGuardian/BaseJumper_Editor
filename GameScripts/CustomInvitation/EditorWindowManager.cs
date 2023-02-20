using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class EditorWindowManager : MonoBehaviour
	{
		private static EditorWindowManager _instance;

		public Color[] rarityColors;

		public Sprite[] chapterSprites;

		public Sprite[] chapterBgSprites;

		public Sprite[] rangeSprites;

		[Header("Story Editor")]
		[SerializeField]
		private GameObject _storyRootObj;

		[SerializeField]
		private StoryListViewer _storyListViewer;

		[Header("Invitation Editor")]
		[SerializeField]
		private Image _imageBlockingMainWindow;

		[SerializeField]
		private Canvas _invitationEditorCanvas;

		[SerializeField]
		private GameObject _invitationObjWithoutCanvas;

		[SerializeField]
		private List<GameObject> _editorWindowList;

		public static EditorWindowManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetInvitationObj()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateStoryEditor(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EditorWindowManager()
		{
			throw null;
		}
	}
}
