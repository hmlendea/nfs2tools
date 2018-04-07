using System.Xml.Serialization;

namespace NFS2Tools.Models
{
    public class LocalisationEntry
    {
        [XmlAttribute]
        public string Key { get; set; }

        public string Value { get; set; }

        public byte[] UnknownBytes { get; set; }

        public LocalisationEntry()
        {
        }

        public LocalisationEntry(string key, string value, byte[] unknownBytes)
        {
            Key = key;
            Value = value;
            UnknownBytes = unknownBytes;
        }
    }
}
