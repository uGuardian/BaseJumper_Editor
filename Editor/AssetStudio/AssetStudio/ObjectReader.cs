using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AssetStudio
{
    public class ObjectReader : EndianBinaryReader
    {
        public SerializedFile assetsFile;
        public long m_PathID;
        public long byteStart;
        public uint byteSize;
        public ClassIDType type;
        public SerializedType serializedType;
        public BuildTarget platform;
        public SerializedFileFormatVersion m_Version;

        public int[] version => assetsFile.version;
        public BuildType buildType => assetsFile.buildType;

        public ObjectReader(EndianBinaryReader reader, SerializedFile assetsFile, ObjectInfo objectInfo) : base(reader.BaseStream, reader.Endian)
        {
            this.assetsFile = assetsFile;
            m_PathID = objectInfo.m_PathID;
            byteStart = objectInfo.byteStart;
            byteSize = objectInfo.byteSize;
            if (Enum.IsDefined(typeof(ClassIDType), objectInfo.classID))
            {
                type = (ClassIDType)objectInfo.classID;
            }
            else
            {
                type = ClassIDType.UnknownType;
            }
            serializedType = objectInfo.serializedType;
            platform = assetsFile.m_TargetPlatform;
            m_Version = assetsFile.header.m_Version;
        }
        public ObjectReader(ObjectWriter writer) : base(writer.BaseStream, writer.Endian)
        {
            assetsFile = writer.assetsFile;
            m_PathID = writer.m_PathID;
            byteStart = writer.byteStart;
            byteSize = writer.byteSize;
            type = writer.type;
            serializedType = writer.serializedType;
            platform = writer.platform;
            m_Version = writer.m_Version;
        }
        public static implicit operator ObjectReader(ObjectWriter writer) => new ObjectReader(writer);

        public void Reset()
        {
            Position = byteStart;
        }
    }
}
