using System;
using System.IO;
using System.Xml.Serialization;

using NFS2Tools.DataAccess.IO.Interfaces;

namespace NFS2Tools.DataAccess.IO
{
    /// <summary>
    /// XML Manager.
    /// </summary>
    public class XmlManager<T> : IXmlManager<T>
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:XmlManager"/> class.
        /// </summary>
        public XmlManager()
        {
            Type = typeof(T);
        }

        /// <summary>
        /// Reads a <see cref="T"/> from an XML file.
        /// </summary>
        /// <param name="path">Path.</param>
        public T Read(string path)
        {
            T instance;

            using (TextReader reader = new StreamReader(path))
            {
                XmlSerializer xml = new XmlSerializer(Type);
                instance = (T)xml.Deserialize(reader);
            }

            return instance;
        }

        /// <summary>
        /// Writes the specified <see cref="T"/> into an XML file.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="obj">Object to write.</param>
        public void Write(string path, T obj)
        {
            using (TextWriter writer = new StreamWriter(path))
            {
                XmlSerializer xml = new XmlSerializer(Type);
                xml.Serialize(writer, obj);
            }
        }
    }
}

