using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// Lap record mapping extensions for converting between entities and domain models.
    /// </summary>
    static class ShpiMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="shpiEntity">Shpi entity.</param>
        internal static Shpi ToDomainModel(this ShpiEntity shpiEntity)
        {
            Shpi shpi = new Shpi
            {
                FileLength = shpiEntity.FileLength,
                ObjectsCount = shpiEntity.ObjectsCount,
                DirectoryId = shpiEntity.DirectoryId
            };

            return shpi;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="shpi">Shpi.</param>
        internal static ShpiEntity ToEntity(this Shpi shpi)
        {
            ShpiEntity shpiEntity = new ShpiEntity
            {
                FileLength = shpi.FileLength,
                ObjectsCount = shpi.ObjectsCount,
                DirectoryId = shpi.DirectoryId
            };

            return shpiEntity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="shpiEntities">Shpi entities.</param>
        internal static IEnumerable<Shpi> ToDomainModels(this IEnumerable<ShpiEntity> shpiEntities)
        {
            IEnumerable<Shpi> shpis = shpiEntities.Select(shpiEntity => shpiEntity.ToDomainModel());

            return shpis;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="shpis">Shpis.</param>
        internal static IEnumerable<ShpiEntity> ToEntities(this IEnumerable<Shpi> shpis)
        {
            IEnumerable<ShpiEntity> shpiEntities = shpis.Select(shpi => shpi.ToEntity());

            return shpiEntities;
        }
    }
}
