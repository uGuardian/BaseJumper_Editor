using System;
using System.IO;
using System.Text;

namespace AssetStudio
{
    public static class BinaryWriterExtensions
    {
        public static void AlignStream(this BinaryWriter writer)
        {
            writer.AlignStream(4);
        }

        public static void AlignStream(this BinaryWriter writer, int alignment)
        {
            var pos = writer.BaseStream.Position;
            var mod = pos % alignment;
            if (mod != 0)
            {
                writer.BaseStream.Position += alignment - mod;
            }
        }

        public static void WriteAlignedString(this BinaryWriter writer, string str)
        {
            var length = str.Length;
            writer.Write(length);
            if (length > 0)
            {
                var stringBytes = Encoding.UTF8.GetBytes(str);
                writer.Write(stringBytes);
                writer.AlignStream(4);
            }
        }
    }
}
