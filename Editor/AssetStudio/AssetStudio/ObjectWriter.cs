using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AssetStudio
{
    public class ObjectWriter : EndianBinaryWriter
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

        public ObjectWriter(EndianBinaryWriter writer, SerializedFile assetsFile, ObjectInfo objectInfo) : base(writer.BaseStream, writer.Endian)
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
        public ObjectWriter(ObjectReader reader) : base(reader.BaseStream, reader.Endian)
        {
            assetsFile = reader.assetsFile;
            m_PathID = reader.m_PathID;
            byteStart = reader.byteStart;
            byteSize = reader.byteSize;
            type = reader.type;
            serializedType = reader.serializedType;
            platform = reader.platform;
            m_Version = reader.m_Version;
        }
        public static implicit operator ObjectWriter(ObjectReader reader) => new ObjectWriter(reader);

        public void Reset()
        {
            Position = byteStart;
        }
    }
}
