using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.Service.Mapping
{
    /// <summary>
    /// LocalisationEntry mapping extensions for converting between data objects and domain models.
    /// </summary>
    static class LocalisationEntryMappingExtensions
    {
        /// <summary>
        /// Converts the data object into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="dataObject">The data object.</param>
        internal static LocalisationEntry ToDomainModel(this LocalisationEntryEntity dataObject) => new()
        {
            Value = dataObject.Value,
            UnknownBytes = dataObject.UnknownBytes
        };

        /// <summary>
        /// Converts the domain model into a data object.
        /// </summary>
        /// <returns>The data object.</returns>
        /// <param name="domainModel">The domain model.</param>
        internal static LocalisationEntryEntity ToDataObject(this LocalisationEntry domainModel) => new()
        {
            Value = domainModel.Value,
            UnknownBytes = domainModel.UnknownBytes
        };

        /// <summary>
        /// Converts the data objects into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="dataObjects">The data objects.</param>
        internal static IEnumerable<LocalisationEntry> ToDomainModels(this IEnumerable<LocalisationEntryEntity> dataObjects)
            => dataObjects.Select(dataObject => dataObject.ToDomainModel());

        /// <summary>
        /// Converts the domain models into data objects.
        /// </summary>
        /// <returns>The data objects.</returns>
        /// <param name="domainModels">The domain models.</param>
        internal static IEnumerable<LocalisationEntryEntity> ToDataObjects(this IEnumerable<LocalisationEntry> domainModels)
            => domainModels.Select(domainModel => domainModel.ToDataObject());
    }
}
