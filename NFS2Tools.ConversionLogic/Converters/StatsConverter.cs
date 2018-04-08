using NFS2Tools.ConversionLogic.Mapping;
using NFS2Tools.DataAccess.IO;
using NFS2Tools.DataAccess.IO.Interfaces;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Converters
{
    /// <summary>
    /// STF converter.
    /// </summary>
    public class StatsConverter : Interfaces.StatsConverter
    {
        readonly IStatsFile stf;
        readonly IXmlManager<TrackRecords> xmlManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatsConverter"/> class.
        /// </summary>
        public StatsConverter()
        {
            stf = new StatsFile();
            xmlManager = new XmlManager<TrackRecords>();
        }

        /// <summary>
        /// Converts an STF into an XML.
        /// </summary>
        /// <param name="stfPath">STF path.</param>
        /// <param name="xmlPath">XML path.</param>
        public void ConvertToXML(string stfPath, string xmlPath)
        {
            TrackRecords records = stf.Read(stfPath).ToDomainModel();

            xmlManager.Write(xmlPath, records);
        }

        /// <summary>
        /// Converts an XML into an STF.
        /// </summary>
        /// <param name="xmlPath">XML path.</param>
        /// <param name="stfPath">STF path.</param>
        public void ConvertToSTF(string xmlPath, string stfPath)
        {
            TrackRecords records = xmlManager.Read(xmlPath);

            stf.Write(stfPath, records.ToEntity());
        }
    }
}
