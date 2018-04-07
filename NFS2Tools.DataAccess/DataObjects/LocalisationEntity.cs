using System.Collections.Generic;

namespace NFS2Tools.DataAccess.DataObjects
{
    public class LocalisationEntity
    {
        public byte[] Unknown1 { get; set; }

        public byte[] Unknown2 { get; set; }

        public IDictionary<string, string> Entries { get; set; }
    }
}
