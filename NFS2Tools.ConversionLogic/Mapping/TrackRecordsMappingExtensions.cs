using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// <see cref="TrackRecords"/> mapping extensions for converting between <see cref="TrackRecords"/> and <see cref="TrackRecordsEntity"/>.
    /// </summary>
    static class TrackRecordsMappingExtensions
    {
        /// <summary>
        /// Converts the current <see cref="TrackRecordsEntity"/> into a <see cref="TrackRecords"/>.
        /// </summary>
        /// <returns>The <see cref="TrackRecords"/>.</returns>
        /// <param name="entity">The current <see cref="TrackRecordsEntity"/>.</param>
        internal static TrackRecords ToDomainModel(this TrackRecordsEntity entity)
        {
            TrackRecords model = new TrackRecords
            {
                BestLapRecord = entity.LapRecords[0].ToDomainModel(),
                RecordsFor2Laps = entity.LapRecords.Skip(1).Take(10).ToDomainModels().ToList(),
                RecordsFor4Laps = entity.LapRecords.Skip(11).Take(10).ToDomainModels().ToList(),
                RecordsFor8Laps = entity.LapRecords.Skip(21).Take(10).ToDomainModels().ToList(),
            };

            return model;
        }

        /// <summary>
        /// Converts the current <see cref="TrackRecords"/> into a <see cref="TrackRecordsEntity"/>.
        /// </summary>
        /// <returns>The <see cref="TrackRecordsEntity"/>.</returns>
        /// <param name="model">The current <see cref="TrackRecords"/>.</param>
        internal static TrackRecordsEntity ToEntity(this TrackRecords model)
        {
            TrackRecordsEntity entity = new TrackRecordsEntity
            {
                LapRecords = new LapRecord[] { model.BestLapRecord }
                    .Concat(model.RecordsFor2Laps)
                    .Concat(model.RecordsFor4Laps)
                    .Concat(model.RecordsFor8Laps)
                    .ToEntities().ToArray()
            };

            return entity;
        }

        /// <summary>
        /// Converts the current <see cref="TrackRecordsEntity"/> collection into a <see cref="TrackRecords"/> collection.
        /// </summary>
        /// <returns>The <see cref="TrackRecords"/> collection.</returns>
        /// <param name="trackRecordsEntities">The current <see cref="TrackRecordsEntity"/> collection.</param>
        internal static IEnumerable<TrackRecords> ToDomainModels(this IEnumerable<TrackRecordsEntity> trackRecordsEntities)
        {
            IEnumerable<TrackRecords> trackRecords = trackRecordsEntities.Select(tre => tre.ToDomainModel());

            return trackRecords;
        }

        /// <summary>
        /// Converts the current <see cref="TrackRecords"/> collection into a <see cref="TrackRecordsEntity"/> collection.
        /// </summary>
        /// <returns>The <see cref="TrackRecordsEntity"/> collection.</returns>
        /// <param name="trackRecords">The current <see cref="TrackRecords"/> collection.</param>
        internal static IEnumerable<TrackRecordsEntity> ToEntities(this IEnumerable<TrackRecords> trackRecords)
        {
            IEnumerable<TrackRecordsEntity> trackRecordsEntity = trackRecords.Select(tr => tr.ToEntity());

            return trackRecordsEntity;
        }
    }
}
