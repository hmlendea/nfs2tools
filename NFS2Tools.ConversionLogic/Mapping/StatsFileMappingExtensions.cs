using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// Lap record mapping extensions for converting between entities and domain models.
    /// </summary>
    static class StatsFileMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="statsFileEntity">StatsFile entity.</param>
        internal static StatsFile ToDomainModel(this StatsFileEntity statsFileEntity)
        {
            StatsFile statsFile = new StatsFile
            {
                LapRecords = statsFileEntity.LapRecords.ToList().ToDomainModels()
            };

            return statsFile;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="statsFile">StatsFile.</param>
        internal static StatsFileEntity ToEntity(this StatsFile statsFile)
        {
            StatsFileEntity statsFileEntity = new StatsFileEntity
            {
                LapRecords = statsFile.LapRecords.ToEntities().ToArray()
            };

            return statsFileEntity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="statsFileEntities">StatsFile entities.</param>
        internal static IEnumerable<StatsFile> ToDomainModels(this IEnumerable<StatsFileEntity> statsFileEntities)
        {
            IEnumerable<StatsFile> statsFiles = statsFileEntities.Select(statsFileEntity => statsFileEntity.ToDomainModel());

            return statsFiles;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="statsFiles">StatsFiles.</param>
        internal static IEnumerable<StatsFileEntity> ToEntities(this IEnumerable<StatsFile> statsFiles)
        {
            IEnumerable<StatsFileEntity> statsFileEntities = statsFiles.Select(statsFile => statsFile.ToEntity());

            return statsFileEntities;
        }
    }
}
