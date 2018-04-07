namespace NFS2Tools.ConversionLogic.Converters.Interfaces
{
    public interface ILocalisationConverter
    {
        /// <summary>
        /// Converts a localisation file into an XML.
        /// </summary>
        /// <param name="inputPath">Localisation file path.</param>
        /// <param name="outputPath">XML path.</param>
        void ConvertToXML(string inputPath, string outputPath);

        /// <summary>
        /// Converts an XML into a localisation file.
        /// </summary>
        /// <param name="inputPath">XML path.</param>
        /// <param name="outputPath">Localisation file path.</param>
        void ConvertToLocalisationFile(string inputPath, string outputPath);
    }
}
