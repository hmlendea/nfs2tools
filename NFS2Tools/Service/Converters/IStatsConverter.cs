namespace NFS2Tools.Service.Converters
{
    public interface IStatsConverter
    {
        void ConvertToXML(string stfPath, string xmlPath);

        void ConvertToSTF(string xmlPath, string stfPath);
    }
}
