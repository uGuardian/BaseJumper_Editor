using System.IO;
using System.Linq;

namespace AssetStudio
{
    public class FileWriter : EndianBinaryWriter
    {
        public string FullPath;
        public string FileName;
        public FileType FileType;

        public FileWriter(FileReader reader) : base(reader.BaseStream, EndianType.BigEndian)
        {
            FullPath = reader.FullPath;
            FileName = reader.FileName;
            FileType = reader.FileType;
        }
        public static implicit operator FileWriter(FileReader reader) => new FileWriter(reader);
    }
}
