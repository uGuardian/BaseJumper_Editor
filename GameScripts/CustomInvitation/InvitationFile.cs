using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class InvitationFile
	{
		[XmlElement("Stage")]
		public FileInfo stageFile;

		[XmlElement("EnemyUnit")]
		public FileInfo enemyUnitFile;

		[XmlElement("EquipPage_Enemy")]
		public FileInfo enemyEquipPage;

		[XmlElement("EquipPage_Librarian")]
		public FileInfo librarianEquipPage;

		[XmlElement("DropBook")]
		public FileInfo dropBookFile;

		[XmlElement("CardDropTable")]
		public FileInfo cardDropTableFile;

		[XmlElement("CardInfo")]
		public FileInfo combatPageFile;

		[XmlElement("Deck")]
		public FileInfo enemyDeckFile;

		[XmlElement("Dialog")]
		public FileInfo dialogFile;

		[XmlElement("BookDesc")]
		public FileInfo bookStoryFile;

		[XmlElement("Passive")]
		public FileInfo passiveFile;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InvitationFile()
		{
			throw null;
		}
	}
}
