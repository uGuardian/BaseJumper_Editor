using System;
using System.Buffers.Binary;
using System.IO;

namespace AssetStudio
{
    public class EndianBinaryWriter : BinaryWriterVerbose
    {
        protected readonly byte[] buffer;

        public EndianType Endian;

        public EndianBinaryWriter(Stream stream, EndianType endian = EndianType.BigEndian) : base(stream)
        {
            Endian = endian;
            buffer = new byte[8];
        }

        public long Position
        {
            get => BaseStream.Position;
            set => BaseStream.Position = value;
        }

        public override void WriteInt16(short value)
        {
            if (Endian == EndianType.BigEndian)
            {
                BinaryPrimitives.WriteInt16BigEndian(buffer, value);
                Write(buffer, 0, 2);
                return;
            }
            base.WriteInt16(value);
        }

        public override void WriteInt32(int value)
        {
            if (Endian == EndianType.BigEndian)
            {
                BinaryPrimitives.WriteInt32BigEndian(buffer, value);
                Write(buffer, 0, 4);
                return;
            }
            base.WriteInt32(value);
        }

        public override void WriteInt64(long value)
        {
            if (Endian == EndianType.BigEndian)
            {
                BinaryPrimitives.WriteInt64BigEndian(buffer, value);
                Write(buffer, 0, 8);
                return;
            }
            base.WriteInt64(value);
        }

        public override void WriteUInt16(ushort value)
        {
            if (Endian == EndianType.BigEndian)
            {
                BinaryPrimitives.WriteUInt16BigEndian(buffer, value);
                Write(buffer, 0, 2);
                return;
            }
            base.WriteUInt16(value);
        }

        public override void WriteUInt32(uint value)
        {
            if (Endian == EndianType.BigEndian)
            {
                BinaryPrimitives.WriteUInt32BigEndian(buffer, value);
                Write(buffer, 0, 4);
                return;
            }
            base.WriteUInt32(value);
        }

        public override void WriteUInt64(ulong value)
        {
            if (Endian == EndianType.BigEndian)
            {
                BinaryPrimitives.WriteUInt64BigEndian(buffer, value);
                Write(buffer, 0, 8);
                return;
            }
            base.WriteUInt64(value);
        }

        public override void WriteSingle(float value)
        {
            if (Endian == EndianType.BigEndian)
            {
				BitConverter.GetBytes(value).CopyTo(buffer, 0);
                Array.Reverse(buffer, 0, 4);
                Write(buffer, 0, 4);
                return;
            }
            base.WriteSingle(value);
        }

        public override void WriteDouble(double value)
        {
            if (Endian == EndianType.BigEndian)
            {
                BitConverter.GetBytes(value).CopyTo(buffer, 0);
                Array.Reverse(buffer);
                Write(buffer, 0, 8);
                return;
            }
            base.WriteDouble(value);
        }
    }
}
