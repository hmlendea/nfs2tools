namespace NFS2Tools.DataAccess.DataObjects
{
    public class FshEntryHeaderEntity
    {
        public int Code { get; set; }

        public short Width { get; set; }

        public short Height { get; set; }

        public short[] Misc { get; set; }

        public FshEntryHeaderEntity()
        {
            Misc = new short[4];
        }
    }
}
