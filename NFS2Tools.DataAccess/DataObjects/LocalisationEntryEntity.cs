namespace NFS2Tools.DataAccess.DataObjects
{
    public class LocalisationEntryEntity
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public short Offset { get; set; }

        public byte[] UnknownBytes { get; set; }
    }
}
