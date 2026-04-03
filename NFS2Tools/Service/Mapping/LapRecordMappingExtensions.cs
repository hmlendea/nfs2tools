using System;
using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.Service.Mapping
{
    /// <summary>
    /// LapRecord mapping extensions for converting between data objects and domain models.
    /// </summary>
    static class LapRecordMappingExtensions
    {
        /// <summary>
        /// Converts the data object into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="dataObject">The data object.</param>
        internal static LapRecord ToDomainModel(this LapRecordEntity dataObject) => new()
        {
            PlayerName = dataObject.PlayerName,
            Car = (CarType)dataObject.CarId,
            Time = (float)RoundDown((float)dataObject.Time / 16384, 2),
            RaceType = (RaceType)dataObject.RaceType
        };

        /// <summary>
        /// Converts the domain model into a data object.
        /// </summary>
        /// <returns>The data object.</returns>
        /// <param name="domainModel">The domain model.</param>
        internal static LapRecordEntity ToDataObject(this LapRecord domainModel) => new()
        {
            PlayerName = domainModel.PlayerName.PadRight(8, '\t')[..8],
            CarId = (short)domainModel.Car,
            Time = (int)(domainModel.Time * 16384),
            RaceType = (short)domainModel.RaceType
        };

        /// <summary>
        /// Converts the data objects into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="dataObjects">The data objects.</param>
        internal static IEnumerable<LapRecord> ToDomainModels(this IEnumerable<LapRecordEntity> dataObjects)
            => dataObjects.Select(dataObject => dataObject.ToDomainModel());

        /// <summary>
        /// Converts the domain models into data objects.
        /// </summary>
        /// <returns>The data objects.</returns>
        /// <param name="domainModels">The domain models.</param>
        internal static IEnumerable<LapRecordEntity> ToDataObjects(this IEnumerable<LapRecord> domainModels)
            => domainModels.Select(domainModel => domainModel.ToDataObject());

        static double RoundDown(double number, int decimalPlaces)
            => Math.Floor(number * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces);
    }
}
