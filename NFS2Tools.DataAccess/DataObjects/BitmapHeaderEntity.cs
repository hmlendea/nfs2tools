namespace NFS2Tools.DataAccess.DataObjects
{
    public class BitmapHeaderEntity
    {
        public int Size { get; set; }

        public int Offset { get; set; }

        public bool IsNull { get; set; }

        public int Hsz { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public short Planes { get; set; }

        public short Depth { get; set; }

        public int Compression { get; set; }

        public int ImageSize { get; set; }

        public int Xpel { get; set; }

        public int Ypel { get; set; }

        public int Colours { get; set; }

        public int ColourI { get; set; }
    }
}
