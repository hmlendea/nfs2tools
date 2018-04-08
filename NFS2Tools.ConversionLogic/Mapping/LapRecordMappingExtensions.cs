using System;
using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;
using NFS2Tools.Models.Enumerations;

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
                Car = (CarType)lapRecordEntity.CarId,
                Time = (float)RoundDown((float)lapRecordEntity.Time / 16384, 2),
                RaceType = (RaceType)lapRecordEntity.RaceType
            };

            return lapRecord;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="model">LapRecord.</param>
        internal static LapRecordEntity ToEntity(this LapRecord model)
        {
            LapRecordEntity entity = new LapRecordEntity
            {
                PlayerName = model.PlayerName.PadRight(8, '\t').Substring(0, 8),
                CarId = (short)model.Car,
                Time = (int)(model.Time * 16384),
                RaceType = (short)model.RaceType
            };

            return entity;
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

        static double RoundDown(double number, int decimalPlaces)
        {
            return Math.Floor(number * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces);
        }
    }
}
