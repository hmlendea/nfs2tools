using NFS2Tools.ConversionLogic.Converters.Interfaces;
using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.DataAccess.IO;
using NFS2Tools.DataAccess.IO.Interfaces;

namespace NFS2Tools.ConversionLogic.Converters
{
    /// <summary>
    /// Localisation converter.
    /// </summary>
    public class LocalisationConverter : ILocalisationConverter
    {
        readonly LocalisationFile localisationFile;
        readonly IXmlManager<LocalisationEntity> xmlManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalisationConverter"/> class.
        /// </summary>
        public LocalisationConverter()
        {
            localisationFile = new LocalisationFile();
            xmlManager = new XmlManager<LocalisationEntity>();
        }

        /// <summary>
        /// Converts a localisation file into an XML.
        /// </summary>
        /// <param name="inputPath">Localisation file path.</param>
        /// <param name="outputPath">XML path.</param>
        public void ConvertToXML(string inputPath, string outputPath)
        {
            LocalisationEntity locale = localisationFile.Read(inputPath);

            xmlManager.Write(outputPath, locale);
        }

        /// <summary>
        /// Converts an XML into a localisation file.
        /// </summary>
        /// <param name="inputPath">XML path.</param>
        /// <param name="outputPath">Localisation file path.</param>
        public void ConvertToLocalisationFile(string inputPath, string outputPath)
        {
            LocalisationEntity locale = xmlManager.Read(inputPath);

            localisationFile.Write(outputPath, locale);
        }
    }
}
