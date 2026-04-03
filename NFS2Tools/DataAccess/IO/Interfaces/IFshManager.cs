namespace NFS2Tools.DataAccess.IO.Interfaces
{
    public interface IFshManager
    {
        void Read(string path);

        void Write(string path, string statsFileEntity);
    }
}
