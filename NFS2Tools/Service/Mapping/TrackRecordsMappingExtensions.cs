using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.Service.Mapping
{
    /// <summary>
    /// TrackRecords mapping extensions for converting between data objects and domain models.
    /// </summary>
    static class TrackRecordsMappingExtensions
    {
        /// <summary>
        /// Converts the data object into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="dataObject">The data object.</param>
        internal static TrackRecords ToDomainModel(this TrackRecordsEntity entity) => new()
        {
            BestLapRecord = entity.LapRecords[0].ToDomainModel(),
            RecordsFor2Laps = [.. entity.LapRecords.Skip(1).Take(10).ToDomainModels()],
            RecordsFor4Laps = [.. entity.LapRecords.Skip(11).Take(10).ToDomainModels()],
            RecordsFor8Laps = [.. entity.LapRecords.Skip(21).Take(10).ToDomainModels()],
        };

        /// <summary>
        /// Converts the domain model into a data object.
        /// </summary>
        /// <returns>The data object.</returns>
        /// <param name="domainModel">The domain model.</param>
        internal static TrackRecordsEntity ToEntity(this TrackRecords model) => new()
        {
            LapRecords = [.. new LapRecord[] { model.BestLapRecord }
                .Concat(model.RecordsFor2Laps)
                .Concat(model.RecordsFor4Laps)
                .Concat(model.RecordsFor8Laps)
                .ToDataObjects()]
        };

        /// <summary>
        /// Converts the data objects into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="dataObjects">The data objects.</param>
        internal static IEnumerable<TrackRecords> ToDomainModels(this IEnumerable<TrackRecordsEntity> dataObjects)
            => dataObjects.Select(dataObject => dataObject.ToDomainModel());

        /// <summary>
        /// Converts the domain models into data objects.
        /// </summary>
        /// <returns>The data objects.</returns>
        /// <param name="domainModels">The domain models.</param>
        internal static IEnumerable<TrackRecordsEntity> ToEntities(this IEnumerable<TrackRecords> domainModels)
            => domainModels.Select(domainModel => domainModel.ToEntity());
    }
}
