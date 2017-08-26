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
        /// <param name="trackRecordsEntity">The current <see cref="TrackRecordsEntity"/>.</param>
        internal static TrackRecords ToDomainModel(this TrackRecordsEntity trackRecordsEntity)
        {
            TrackRecords trackRecords = new TrackRecords
            {
                LapRecords = trackRecordsEntity.LapRecords.ToList().ToDomainModels()
            };

            return trackRecords;
        }

        /// <summary>
        /// Converts the current <see cref="TrackRecords"/> into a <see cref="TrackRecordsEntity"/>.
        /// </summary>
        /// <returns>The <see cref="TrackRecordsEntity"/>.</returns>
        /// <param name="trackRecords">The current <see cref="TrackRecords"/>.</param>
        internal static TrackRecordsEntity ToEntity(this TrackRecords trackRecords)
        {
            TrackRecordsEntity trackRecordsEntity = new TrackRecordsEntity
            {
                LapRecords = trackRecords.LapRecords.ToEntities().ToArray()
            };

            return trackRecordsEntity;
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
