using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using LOR_XML;

namespace Mod
{
	public class ModContent
	{
		private ModContentInfo _modInfo;

		private DirectoryInfo _dirInfo;

		private Dictionary<string, string> _storyStadingPaths;

		private Dictionary<string, string> _storyCgPaths;

		private Dictionary<string, string> _storyBgmPaths;

		private string _itemUniqueId;

		private string _stageXmlPath;

		private string _enemyUnitXmlPath;

		private string _equipPageLibrarianXmlPath;

		private string _equipPageEnemyXmlPath;

		private string _dropBookXmlPath;

		private string _cardDropTableXmlPath;

		private string _cardInfoXmlPath;

		private string _deckXmlPath;

		private string _dialogXmlPath;

		private string _bookStoryXmlPath;

		private string _passiveXmlPath;

		private string _cardAbilityXmlPath;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, string> GetStoryStandingSet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, string> GetStoryCgSet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, string> GetStoryBgmSet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadAssembly()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ModContent LoadModContent(ModContentInfo modContentInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Loads()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<StageClassInfo> LoadStage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<EnemyUnitClassInfo> LoadEnemyUnit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BookXmlInfo> LoadEquipLibrarianPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BookXmlInfo> LoadEquipEnemyPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<DropBookXmlInfo> LoadDropBook()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<CardDropTableXmlInfo> LoadCardDropTable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<DiceCardXmlInfo> LoadCardInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<DeckXmlInfo> LoadDeck()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BattleDialogCharacter> LoadDialog()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BookDesc> LoadBookStory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<PassiveXmlInfo> LoadPassive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<BattleCardAbilityDesc> LoadAbilityText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadArtworks()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadBookSkins()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadAssemblies()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetDataFilePath(string fileName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModContent()
		{
			throw null;
		}
	}
}
