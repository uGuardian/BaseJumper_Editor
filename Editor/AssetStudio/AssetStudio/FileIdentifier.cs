using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AssetStudio
{
    public class FileIdentifier
    {
        public Guid guid;
        public int type; //enum { kNonAssetType = 0, kDeprecatedCachedAssetType = 1, kSerializedAssetType = 2, kMetaAssetType = 3 };
        public string PathName {
            get {
                return pathName;
            }
            set {
                if (oldPathName == null) {
                    oldPathName = value;
                }
                pathName = value;
            }
        }
        string pathName;
        string oldPathName;

        //custom
        public string fileName;

        public long offset;
        public long midOffset;
        public long endOffset;
        byte[] tempEmpty;
        FileReader reader;
        SerializedFileHeader header;
        public FileIdentifier followingIdentifier;

        public void Read(SerializedFileHeader header, FileReader reader) {
            this.header = header;
            this.reader = reader;
            Read();
        }
        void Read() {
            reader.Position = offset;
            if (header.m_Version >= SerializedFileFormatVersion.Unknown_6)
            {
				tempEmpty = reader.ReadBytesToNull().Append((byte)0).ToArray();
            }
            if (header.m_Version >= SerializedFileFormatVersion.Unknown_5)
            {
                guid = new Guid(reader.ReadBytes(16));
                type = reader.ReadInt32();
            }
            this.midOffset = reader.Position;
            pathName = reader.ReadStringToNull();
            fileName = Path.GetFileName(pathName);
            this.endOffset = reader.Position;
        }
        public void Write() {
            Write(offset);
        }
        public void Write(long offset) {
            reader.Position = offset;
            Write_Internal();
        }
        void Write_Internal() {
            FileWriter writer = reader;
            if (header.m_Version >= SerializedFileFormatVersion.Unknown_6)
            {
                writer.WriteBytes(tempEmpty);
            }
            if (header.m_Version >= SerializedFileFormatVersion.Unknown_5)
            {
				writer.WriteBytes(guid.ToByteArray());
                writer.WriteInt32(type);
            }
			var stringLength = Encoding.UTF8.GetBytes(oldPathName ?? pathName).Length;
            var newStringBytes = Encoding.UTF8.GetBytes(pathName);
            if (newStringBytes.Length != stringLength) {
                if (newStringBytes.Length > stringLength) {
                    Logger.Error("String length exceeded allocated bytes");
                    return;
                }
            }
            writer.WriteBytes(newStringBytes);
            writer.WriteByte(0);
            oldPathName = null;
            if (followingIdentifier != null) {
                followingIdentifier.Write_Internal();
            } else {
                while (writer.Position < endOffset) {
                    writer.WriteByte(0);
                }
            }
            fileName = Path.GetFileName(pathName);
        }
    }
}
