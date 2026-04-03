using System;
using System.IO;
using System.Linq;
using NFS2Tools.DataAccess.IO;
using NFS2Tools.Service.Converters;

namespace NFS2Tools
{
    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {
        static readonly string[] localisationExtensions = ["eng", "fre", "ger", "ita", "spa", "swe"];

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

            string inputExtension = Path.GetExtension(inputPath)[1..].ToLower();
            string outputExtension = Path.GetExtension(outputPath)[1..].ToLower();

            if (inputExtension.Equals(FileType.STF) || outputExtension.Equals(FileType.STF))
            {
                IStatsConverter stfConverter = new StatsConverter();

                if (inputExtension.Equals(FileType.XML))
                {
                    stfConverter.ConvertToSTF(inputPath, outputPath);
                }
                else if (outputExtension.Equals(FileType.XML))
                {
                    stfConverter.ConvertToXML(inputPath, outputPath);
                }
            }

            if (localisationExtensions.Contains(inputExtension) || localisationExtensions.Contains(outputExtension))
            {
                ILocalisationConverter localisationConverter = new LocalisationConverter();

                if (inputExtension.Equals(FileType.XML))
                {
                    localisationConverter.ConvertToLocalisationFile(inputPath, outputPath);
                }

                if (outputExtension.Equals(FileType.XML))
                {
                    localisationConverter.ConvertToXML(inputPath, outputPath);
                }
            }
        }
    }
}
