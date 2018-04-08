using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// Localisation mapping extensions for converting between entities and domain models.
    /// </summary>
    static class LocalisationMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="entity">Localisation entity.</param>
        internal static Localisation ToDomainModel(this LocalisationEntity entity)
        {
            Localisation model = new Localisation
            {
                Unknown1 = entity.Unknown1,
                Unknown2 = entity.Unknown2,
                Unknown3 = entity.Unknown3,
                Entries = entity.Entries.ToDomainModels().ToList()
            };

            return model;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="model">Localisation.</param>
        internal static LocalisationEntity ToEntity(this Localisation model)
        {
            LocalisationEntity entity = new LocalisationEntity
            {
                Unknown1 = model.Unknown1,
                Unknown2 = model.Unknown2,
                Unknown3 = model.Unknown3,
                Entries = model.Entries.ToEntities().ToList()
            };

            return entity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="localisationEntities">Localisation entities.</param>
        internal static IEnumerable<Localisation> ToDomainModels(this IEnumerable<LocalisationEntity> localisationEntities)
        {
            IEnumerable<Localisation> localisations = localisationEntities.Select(localisationEntity => localisationEntity.ToDomainModel());

            return localisations;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="localisations">Localisations.</param>
        internal static IEnumerable<LocalisationEntity> ToEntities(this IEnumerable<Localisation> localisations)
        {
            IEnumerable<LocalisationEntity> localisationEntities = localisations.Select(localisation => localisation.ToEntity());

            return localisationEntities;
        }
    }
}
