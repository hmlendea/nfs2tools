using System;
using System.IO;
using System.Linq;

using NFS2Tools.DataAccess.IO.Interfaces;

namespace NFS2Tools.DataAccess.IO
{
    public class FshManager : IFshManager
    {
        public void Read(string path)
        {
            byte[] inbuf = File.ReadAllBytes(path);
            bool isCompressed = false;

            if ((inbuf[0] & 0xFE) == 0x10)
            {
                // It's a compressed QFS
                isCompressed = true;

                Console.WriteLine($"Decompressing QFS file ({inbuf.Length})");
            }
        }

        public void Write(string path, string statsFileEntity)
        {

        }

        byte[] UncompressData(byte[] inbuf)
        {
            byte[] outbuf;
            byte packCode;

            int a, b, c, len, offset;
            int inLen, outLen, inPos, outPos;

            // Length of the data
            inLen = inbuf.Length;
            outLen = (inbuf[2] << 16) + (inbuf[3] << 8) + inbuf[4];
            outbuf = new byte[outLen];

            // Position in the file
            if ((inbuf[0] & 0x01) != 0)
            {
                inPos = 8;
            }
            else
            {
                inPos = 5;
            }
            outPos = 0;

            // Main decompression
            while ((inPos < inLen) && (inbuf[inPos] < 0xFC))
            {
                packCode = inbuf[inPos];
                a = inbuf[inPos + 1];
                b = inbuf[inPos + 2];

                if ((packCode & 0x80) == 0)
                {
                    len = packCode & 3;
                }
            }

            return null;
        }
    }
}
