using System;
using System.IO;

using NFS2Tools.ConversionLogic.Converters;
using NFS2Tools.ConversionLogic.Converters.Interfaces;

namespace NFS2Tools
{
    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {
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

            string path1 = args[0];
            string path2 = args[1];

            string extension1 = Path.GetExtension(path1).Substring(1).ToLower();
            string extension2 = Path.GetExtension(path2).Substring(1).ToLower();

            if (extension1 == "stf" || extension2 == "stf")
            {
                IStfConverter stfConverter = new StfConverter();

                if (extension1 == "xml")
                {
                    stfConverter.ConvertToSTF(path1, path2);
                }
                else if (extension2 == "xml")
                {
                    stfConverter.ConvertToXML(path1, path2);
                }
            }
        }
    }
}
