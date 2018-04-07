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

        public bool IsBigEndian { get; }

        public virtual Stream BaseStream => stream;

        public NfsFileWriter(string filePath, FileMode fileMode)
        {
            FilePath = filePath;

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

        public void WriteInt16(short value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (IsBigEndian)
            {
                Array.Reverse(bytes);
            }

            WriteBytes(bytes);
        }

        public void WriteInt32(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            if (IsBigEndian)
            {
                Array.Reverse(bytes);
            }

            WriteBytes(bytes);
        }
    }
}
