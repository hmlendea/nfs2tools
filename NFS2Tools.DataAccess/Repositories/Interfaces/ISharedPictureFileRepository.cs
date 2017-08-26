using NFS2Tools.DataAccess.DataObjects;

namespace NFS2Tools.DataAccess.Repositories.Interfaces
{
    public interface ISharedPictureFileRepository
    {
        void Add(SharedPictureFileEntity sharedPictureFileEntity);

        SharedPictureFileEntity Get(string path);
    }
}
