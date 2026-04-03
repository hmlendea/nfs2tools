namespace NFS2Tools.DataAccess.IO
{
    public interface IXmlManager<T>
    {
        T Read(string path);

        void Write(string path, T obj);
    }
}
