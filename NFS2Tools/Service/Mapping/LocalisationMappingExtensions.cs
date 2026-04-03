using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.Service.Mapping
{
    /// <summary>
    /// Localisation mapping extensions for converting between data objects and domain models.
    /// </summary>
    static class LocalisationMappingExtensions
    {
        /// <summary>
        /// Converts the data object into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="dataObject">The data object.</param>
        internal static Localisation ToDomainModel(this LocalisationEntity dataObject) => new()
        {
            Unknown1 = dataObject.Unknown1,
            Unknown2 = dataObject.Unknown2,
            Unknown3 = dataObject.Unknown3,
            Entries = [.. dataObject.Entries.ToDomainModels()]
        };

        /// <summary>
        /// Converts the domain model into a data object.
        /// </summary>
        /// <returns>The data object.</returns>
        /// <param name="domainModel">The domain model.</param>
        internal static LocalisationEntity ToEntity(this Localisation model) => new()
        {
            Unknown1 = model.Unknown1,
            Unknown2 = model.Unknown2,
            Unknown3 = model.Unknown3,
            Entries = [.. model.Entries.ToDataObjects()]
        };

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="dataObjects">Localisation entities.</param>
        internal static IEnumerable<Localisation> ToDomainModels(this IEnumerable<LocalisationEntity> dataObjects)
            => dataObjects.Select(dataObject => dataObject.ToDomainModel());

        /// <summary>
        /// Converts the data objects into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="dataObjects">The data objects.</param>
        internal static IEnumerable<LocalisationEntity> ToEntities(this IEnumerable<Localisation> dataObjects)
            => dataObjects.Select(dataObject => dataObject.ToEntity());
    }
}
