namespace NFS2Tools.ConversionLogic.Converters.Interfaces
{
    public interface IStfConverter
    {
        void ConvertToXML(string stfPath, string xmlPath);

        void ConvertToSTF(string xmlPath, string stfPath);
    }
}
