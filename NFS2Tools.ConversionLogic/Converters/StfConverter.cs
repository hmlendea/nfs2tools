using NFS2Tools.ConversionLogic.Converters.Interfaces;
using NFS2Tools.ConversionLogic.Mapping;
using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.DataAccess.IO;
using NFS2Tools.DataAccess.IO.Interfaces;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Converters
{
    /// <summary>
    /// STF converter.
    /// </summary>
    public class StfConverter : IStfConverter
    {
        readonly IStfManager stfManager;
        readonly IXmlManager<TrackRecordsEntity> xmlManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="StfConverter"/> class.
        /// </summary>
        public StfConverter()
        {
            stfManager = new StfManager();
            xmlManager = new XmlManager<TrackRecordsEntity>();
        }

        /// <summary>
        /// Converts an STF into an XML.
        /// </summary>
        /// <param name="stfPath">STF path.</param>
        /// <param name="xmlPath">XML path.</param>
        public void ConvertToXML(string stfPath, string xmlPath)
        {
            TrackRecords records = stfManager.Read(stfPath).ToDomainModel();

            xmlManager.Write(xmlPath, records.ToEntity());
        }

        /// <summary>
        /// Converts an XML into an STF.
        /// </summary>
        /// <param name="xmlPath">XML path.</param>
        /// <param name="stfPath">STF path.</param>
        public void ConvertToSTF(string xmlPath, string stfPath)
        {
            TrackRecords records = xmlManager.Read(xmlPath).ToDomainModel();

            stfManager.Write(stfPath, records.ToEntity());
        }
    }
}
