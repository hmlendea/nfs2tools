using NFS2Tools.ConversionLogic.Converters.Interfaces;
using NFS2Tools.ConversionLogic.Mapping;
using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.DataAccess.IO;
using NFS2Tools.DataAccess.IO.Interfaces;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Converters
{
    /// <summary>
    /// Localisation converter.
    /// </summary>
    public class LocalisationConverter : ILocalisationConverter
    {
        readonly LocalisationFile localisationFile;
        readonly IXmlManager<Localisation> xmlManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalisationConverter"/> class.
        /// </summary>
        public LocalisationConverter()
        {
            localisationFile = new LocalisationFile();
            xmlManager = new XmlManager<Localisation>();
        }

        /// <summary>
        /// Converts a localisation file into an XML.
        /// </summary>
        /// <param name="inputPath">Localisation file path.</param>
        /// <param name="outputPath">XML path.</param>
        public void ConvertToXML(string inputPath, string outputPath)
        {
            Localisation locale = localisationFile.Read(inputPath).ToDomainModel();

            xmlManager.Write(outputPath, locale);
        }

        /// <summary>
        /// Converts an XML into a localisation file.
        /// </summary>
        /// <param name="inputPath">XML path.</param>
        /// <param name="outputPath">Localisation file path.</param>
        public void ConvertToLocalisationFile(string inputPath, string outputPath)
        {
            LocalisationEntity locale = xmlManager.Read(inputPath).ToEntity();

            localisationFile.Write(outputPath, locale);
        }
    }
}
