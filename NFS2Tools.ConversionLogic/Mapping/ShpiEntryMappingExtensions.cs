using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// Lap record mapping extensions for converting between entities and domain models.
    /// </summary>
    static class ShpiEntryMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="shpiEntryEntity">ShpiEntry entity.</param>
        internal static ShpiEntry ToDomainModel(this ShpiEntryEntity shpiEntryEntity)
        {
            ShpiEntry shpiEntry = new ShpiEntry
            {
                BitmapSize = new Size(shpiEntryEntity.BitmapWidth, shpiEntryEntity.BitmapHeight),
                DisplayLocation = new Point(shpiEntryEntity.DisplayLocationX, shpiEntryEntity.DisplayLocationY)
            };

            return shpiEntry;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="shpiEntry">ShpiEntry.</param>
        internal static ShpiEntryEntity ToEntity(this ShpiEntry shpiEntry)
        {
            ShpiEntryEntity shpiEntryEntity = new ShpiEntryEntity
            {
                BitmapWidth = shpiEntry.BitmapSize.Width,
                BitmapHeight = shpiEntry.BitmapSize.Height,
                DisplayLocationX = shpiEntry.DisplayLocation.X,
                DisplayLocationY = shpiEntry.DisplayLocation.Y
            };

            return shpiEntryEntity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="shpiEntryEntities">ShpiEntry entities.</param>
        internal static IEnumerable<ShpiEntry> ToDomainModels(this IEnumerable<ShpiEntryEntity> shpiEntryEntities)
        {
            IEnumerable<ShpiEntry> shpiEntries = shpiEntryEntities.Select(shpiEntryEntity => shpiEntryEntity.ToDomainModel());

            return shpiEntries;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="shpiEntries">ShpiEntries.</param>
        internal static IEnumerable<ShpiEntryEntity> ToEntities(this IEnumerable<ShpiEntry> shpiEntries)
        {
            IEnumerable<ShpiEntryEntity> shpiEntryEntities = shpiEntries.Select(shpiEntry => shpiEntry.ToEntity());

            return shpiEntryEntities;
        }
    }
}
