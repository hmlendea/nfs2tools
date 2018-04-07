using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// LocalisationEntry mapping extensions for converting between entities and domain models.
    /// </summary>
    static class LocalisationEntryMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="entity">LocalisationEntry entity.</param>
        internal static LocalisationEntry ToDomainModel(this LocalisationEntryEntity entity)
        {
            LocalisationEntry model = new LocalisationEntry
            {
                Key = entity.Key,
                Value = entity.Value,
                UnknownBytes = entity.UnknownBytes
            };

            return model;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="model">LocalisationEntry.</param>
        internal static LocalisationEntryEntity ToEntity(this LocalisationEntry model)
        {
            LocalisationEntryEntity entity = new LocalisationEntryEntity
            {
                Key = model.Key,
                Value = model.Value,
                UnknownBytes = model.UnknownBytes
            };

            return entity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="localisationEntryEntities">LocalisationEntry entities.</param>
        internal static IEnumerable<LocalisationEntry> ToDomainModels(this IEnumerable<LocalisationEntryEntity> localisationEntryEntities)
        {
            IEnumerable<LocalisationEntry> localisationEntries = localisationEntryEntities.Select(localisationEntryEntity => localisationEntryEntity.ToDomainModel());

            return localisationEntries;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="localisationEntries">LocalisationEntries.</param>
        internal static IEnumerable<LocalisationEntryEntity> ToEntities(this IEnumerable<LocalisationEntry> localisationEntries)
        {
            IEnumerable<LocalisationEntryEntity> localisationEntryEntities = localisationEntries.Select(localisationEntry => localisationEntry.ToEntity());

            return localisationEntryEntities;
        }
    }
}
