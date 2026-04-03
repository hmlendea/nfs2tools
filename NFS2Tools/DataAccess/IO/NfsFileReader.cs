using System;
using System.IO;

namespace NFS2Tools.DataAccess.IO
{
    public class NfsFileReader : IDisposable
    {
        Stream stream;
        bool disposed;

        public string FilePath { get; }

        public virtual Stream BaseStream => stream;

        public Endianness SystemEndianness { get; }

        public Endianness ReaderEndianness { get; set; }

        public NfsFileReader(string filePath, FileMode fileMode)
        {
            FilePath = filePath;
            SystemEndianness = BitConverter.IsLittleEndian ? Endianness.LittleEndian : Endianness.BigEndian;
            ReaderEndianness = SystemEndianness;

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

        public byte ReadByte()
        {
            int b = BaseStream.ReadByte();

            if (b == -1)
            {
                throw new EndOfStreamException();
            }

            return (byte)b;
        }

        public byte[] ReadBytes(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (stream == null)
            {
                throw new ObjectDisposedException(null);
            }

            byte[] bytes = new byte[count];

            for (int i = 0; i < count; i++)
            {
                bytes[i] = ReadByte();
            }

            return bytes;
        }

        public char ReadChar() => (char)ReadByte();

        public string ReadString()
        {
            string str = string.Empty;

            while (stream.Position != stream.Length)
            {
                char c = ReadChar();

                if (c == '\0')
                {
                    return str;
                }

                str += c;
            }

            return str;
        }

        public string ReadString(int count)
        {
            string str = string.Empty;

            while (count > 0)
            {
                char c = ReadChar();

                str += c;
                count -= 1;
            }

            return str.TrimEnd('\0');
        }

        public short ReadInt16() => ReadInt16(ReaderEndianness);

        public short ReadInt16(Endianness endianness)
        {
            byte[] bytes = ReadBytes(2);

            if (endianness != SystemEndianness)
            {
                Array.Reverse(bytes);
            }

            return BitConverter.ToInt16(bytes, 0);
        }

        public int ReadInt32() => ReadInt32(ReaderEndianness);

        public int ReadInt32(Endianness endianness)
        {
            byte[] bytes = ReadBytes(4);

            if (endianness != SystemEndianness)
            {
                Array.Reverse(bytes);
            }

            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
