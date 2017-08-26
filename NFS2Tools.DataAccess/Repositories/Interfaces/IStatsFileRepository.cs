using NFS2Tools.DataAccess.DataObjects;

namespace NFS2Tools.DataAccess.Repositories.Interfaces
{
    public interface IStatsFileRepository
    {
        void Add(StatsFileEntity statsFileEntity);

        StatsFileEntity Get(string path);
    }
}
