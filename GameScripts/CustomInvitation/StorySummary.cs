using System;
using System.Runtime.CompilerServices;
using LOR_XML;
using UnityEngine;
using UnityEngine.UI;
using WorkParser;

namespace CustomInvitation
{
	public class StorySummary : MonoBehaviour
	{
		[SerializeField]
		private Button _openStoryBtn;

		[SerializeField]
		private Text _storyFileText;

		private ScenarioRoot _storyData;

		private SceneEffect _storyEffectData;

		private string _storyPath;

		private string _effectPath;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(string filePath, Action<string, string> clickEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetStoryPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetEffectPath()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Button GetButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitStoryData(string storyFile)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitEffectData(string storyFileName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorySummary()
		{
			throw null;
		}
	}
}
