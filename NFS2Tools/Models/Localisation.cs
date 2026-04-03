using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFS2Tools.Models
{
    public class Localisation
    {
        public byte[] Unknown1 { get; set; }

        public byte[] Unknown2 { get; set; }

        public byte[] Unknown3 { get; set; }

        [XmlElement("Entry")]
        public List<LocalisationEntry> Entries { get; set; }
    }
}
