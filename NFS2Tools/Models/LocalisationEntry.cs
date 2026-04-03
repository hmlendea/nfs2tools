using System.Xml.Serialization;

namespace NFS2Tools.Models
{
    public class LocalisationEntry
    {
        [XmlAttribute]
        public string Value { get; set; }

        [XmlAttribute]
        public byte[] UnknownBytes { get; set; }

        public LocalisationEntry()
        {
        }

        public LocalisationEntry(string value, byte[] unknownBytes)
        {
            Value = value;
            UnknownBytes = unknownBytes;
        }
    }
}
