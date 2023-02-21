using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace AssetStudio
{
    public class PPtrOffset
    {
		public readonly long offset;
		public readonly ObjectReader reader;
		public BinaryWriterVerbose writer => (ObjectWriter)reader;
		public readonly PPtr<Object> pptr;
		public readonly string type;
		public string FullType => m_Node.m_Type;
		public readonly TypeTreeNode m_Node;
		public bool IsLongId => reader.m_Version >= SerializedFileFormatVersion.Unknown_14; 
		public PPtrOffset(TypeTreeNode m_Node, ObjectReader reader, long offset)
        {
			this.m_Node = m_Node;
			reader.Position = offset;
			this.pptr = new PPtr<Object>(reader);
			this.reader = reader;
			this.offset = offset;
			this.type = GetPPtrType(m_Node);
        }

		public static string GetPPtrType(TypeTreeNode m_Node) {
			var nodeType = m_Node.m_Type;
			return nodeType.Substring(nodeType.IndexOf('<') + 1).TrimEnd('>');
		}

		public void WriteFileId(int id) {
			TypeTreeHelper.WriteValue("int",
                GetOffsetBool(m_Node),
                writer,
                offset,
                id
            );
			pptr.m_FileID = id;
		}
		public void WritePathId(long id) {
			if (IsLongId) {
				TypeTreeHelper.WriteValue("SInt64",
					GetOffsetBool(m_Node),
					writer,
					offset + 4,
					id
				);
			} else {
				TypeTreeHelper.WriteValue("int",
					GetOffsetBool(m_Node),
					writer,
					offset + 4,
					(int)id
				);
			}
			pptr.m_PathID = id;
		}
		public static bool GetOffsetBool(TypeTreeNode m_Node) => GetOffsetBool(m_Node.m_MetaFlag);
		public static bool GetOffsetBool(int m_MetaFlag) => (m_MetaFlag & 0x4000) != 0;
	}
}