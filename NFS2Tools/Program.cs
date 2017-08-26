using System;

using NFS2Tools.ConversionLogic.Converters;
using NFS2Tools.ConversionLogic.Converters.Interfaces;

namespace NFS2Tools
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IStfConverter stfConverter = new StfConverter();

            stfConverter.ConvertToXML("/home/horatiu/.nfs2se/oz.stf", "oz.xml");
            stfConverter.ConvertToSTF("oz.xml", "oz.stf");
            stfConverter.ConvertToXML("oz.stf", "oz-reconverted.xml");
        }
    }
}
