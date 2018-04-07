using System.Xml.Serialization;

namespace NFS2Tools.Models
{
    public class LocalisationEntry
    {
        [XmlAttribute]
        public string Key { get; set; }

        [XmlAttribute]
        public string Value { get; set; }

        public LocalisationEntry()
        {
        }

        public LocalisationEntry(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
