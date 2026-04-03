namespace NFS2Tools.Service.Converters.Interfaces
{
    public interface StatsConverter
    {
        void ConvertToXML(string stfPath, string xmlPath);

        void ConvertToSTF(string xmlPath, string stfPath);
    }
}
