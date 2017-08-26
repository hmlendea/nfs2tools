using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// Lap record mapping extensions for converting between entities and domain models.
    /// </summary>
    static class LapRecordMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="lapRecordEntity">LapRecord entity.</param>
        internal static LapRecord ToDomainModel(this LapRecordEntity lapRecordEntity)
        {
            LapRecord lapRecord = new LapRecord
            {
                PlayerName = lapRecordEntity.PlayerName,
                CarId = lapRecordEntity.CarId,
                Time = lapRecordEntity.Time,
                RaceType = lapRecordEntity.RaceType
            };

            return lapRecord;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="lapRecord">LapRecord.</param>
        internal static LapRecordEntity ToEntity(this LapRecord lapRecord)
        {
            LapRecordEntity lapRecordEntity = new LapRecordEntity
            {
                PlayerName = lapRecord.PlayerName,
                CarId = lapRecord.CarId,
                Time = lapRecord.Time,
                RaceType = lapRecord.RaceType
            };

            return lapRecordEntity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="lapRecordEntities">LapRecord entities.</param>
        internal static IEnumerable<LapRecord> ToDomainModels(this IEnumerable<LapRecordEntity> lapRecordEntities)
        {
            IEnumerable<LapRecord> lapRecords = lapRecordEntities.Select(lapRecordEntity => lapRecordEntity.ToDomainModel());

            return lapRecords;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="lapRecords">LapRecords.</param>
        internal static IEnumerable<LapRecordEntity> ToEntities(this IEnumerable<LapRecord> lapRecords)
        {
            IEnumerable<LapRecordEntity> lapRecordEntities = lapRecords.Select(lapRecord => lapRecord.ToEntity());

            return lapRecordEntities;
        }
    }
}
