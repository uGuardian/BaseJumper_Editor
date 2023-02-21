using System;
using System.Buffers.Binary;
using System.IO;
using System.Text;

namespace AssetStudio
{
    public class BinaryWriterVerbose : BinaryWriter
    {
		protected BinaryWriterVerbose() {}

		public BinaryWriterVerbose(Stream output) : base(output) {}

		public BinaryWriterVerbose(Stream output, Encoding encoding) : base(output, encoding) {}

		public BinaryWriterVerbose(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen) {}

        public virtual void WriteBoolean(bool value) => Write(value);

        public virtual void WriteSByte(sbyte value) => Write(value);

		public virtual void WriteInt16(short value) => Write(value);

        public virtual void WriteInt32(int value) => Write(value);

        public virtual void WriteInt64(long value) => Write(value);

        public virtual void WriteByte(byte value) => Write(value);

        public virtual void WriteBytes(byte[] value) => Write(value);

        public virtual void WriteUInt16(ushort value) => Write(value);

        public virtual void WriteUInt32(uint value) => Write(value);

        public virtual void WriteUInt64(ulong value) => Write(value);

        public virtual void WriteSingle(float value) => Write(value);

		public virtual void WriteDouble(double value) => Write(value);
	}
}
