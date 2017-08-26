using NFS2Tools.DataAccess.DataObjects;

namespace NFS2Tools.DataAccess.Repositories.Interfaces
{
    public interface IShpiRepository
    {
        void Add(ShpiEntity shpiEntity);

        ShpiEntity Get(string path);
    }
}
