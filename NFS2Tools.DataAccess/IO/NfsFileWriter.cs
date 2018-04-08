using System;
using System.IO;
using System.Linq;

namespace NFS2Tools.DataAccess.IO
{
    public class NfsFileWriter : IDisposable
    {
        Stream stream;
        bool disposed;

        public string FilePath { get; }

        public bool InvertedEndianness { get; }

        public virtual Stream BaseStream => stream;

        public Endianness SystemEndianness { get; }

        public Endianness WriterEndianness { get; set; }

        public NfsFileWriter(string filePath, FileMode fileMode)
        {
            FilePath = filePath;
            SystemEndianness = BitConverter.IsLittleEndian ? Endianness.LittleEndian : Endianness.BigEndian;
            WriterEndianness = SystemEndianness;

            stream = File.Open(filePath, fileMode);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                stream.Close();
                stream = null;
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Close()
        {
            Dispose();
        }

        public void WriteByte(byte value) => BaseStream.WriteByte(value);

        public void WriteBytes(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                WriteByte(bytes[i]);
            }
        }

        public void WriteChar(char value) => WriteByte((byte)value);

        public void WriteString(string value)
        {
            byte[] strBytes = value.Select(Convert.ToByte).ToArray();

            WriteBytes(strBytes);
            WriteByte(0);
        }

        public void WriteString(string value, int length) => WriteString(value, length, '\0');

        public void WriteString(string value, int length, char paddingChar)
        {
            string str = value;

            if (str.Length > length)
            {
                str = value.Substring(0, length);
            }

            if (str.Length < length)
            {
                str.PadRight(length, paddingChar);
            }

            byte[] strBytes = value.Select(Convert.ToByte).ToArray();

            WriteBytes(strBytes);
            WriteByte(0);
        }

        public void WriteInt16(short value) => WriteInt16(value, WriterEndianness);

        public void WriteInt16(short value, Endianness endianness)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (endianness != SystemEndianness)
            {
                Array.Reverse(bytes);
            }

            WriteBytes(bytes);
        }

        public void WriteInt32(int value) => WriteInt32(value, WriterEndianness);

        public void WriteInt32(int value, Endianness endianness)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (endianness != SystemEndianness)
            {
                Array.Reverse(bytes);
            }

            WriteBytes(bytes);
        }
    }
}
