using System;
using System.IO;
using System.Linq;

using NFS2Tools.ConversionLogic.Converters;
using NFS2Tools.ConversionLogic.Converters.Interfaces;

namespace NFS2Tools
{
    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {
        static string[] localisationExtensions = { "eng", "fre", "ger", "ita", "spa", "swe" };

        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Invalid arguments");
                return;
            }

            string inputPath = args[0];
            string outputPath = args[1];

            string inputExtension = Path.GetExtension(inputPath).Substring(1).ToLower();
            string outputExtension = Path.GetExtension(outputPath).Substring(1).ToLower();

            if (inputExtension == "stf" || outputExtension == "stf")
            {
                ConversionLogic.Converters.Interfaces.StatsConverter stfConverter = new ConversionLogic.Converters.StatsConverter();

                if (inputExtension == "xml")
                {
                    stfConverter.ConvertToSTF(inputPath, outputPath);
                }
                else if (outputExtension == "xml")
                {
                    stfConverter.ConvertToXML(inputPath, outputPath);
                }
            }

            if (localisationExtensions.Contains(inputExtension) || localisationExtensions.Contains(outputExtension))
            {
                ILocalisationConverter localisationConverter = new LocalisationConverter();

                if (inputExtension == "xml")
                {
                    localisationConverter.ConvertToLocalisationFile(inputPath, outputPath);
                }

                if (outputExtension == "xml")
                {
                    localisationConverter.ConvertToXML(inputPath, outputPath);
                }
            }
        }
    }
}
