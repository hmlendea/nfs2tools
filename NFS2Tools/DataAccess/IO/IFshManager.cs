namespace NFS2Tools.DataAccess.IO
{
    public interface IFshManager
    {
        void Read(string path);

        void Write(string path, string statsFileEntity);
    }
}
