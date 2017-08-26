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
    static class SharedPictureMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="sharedPictureEntity">ShpiEntry entity.</param>
        internal static SharedPicture ToDomainModel(this SharedPictureEntity sharedPictureEntity)
        {
            SharedPicture sharedPicture = new SharedPicture
            {
                BitmapSize = new Size(sharedPictureEntity.BitmapWidth, sharedPictureEntity.BitmapHeight),
                DisplayLocation = new Point(sharedPictureEntity.DisplayLocationX, sharedPictureEntity.DisplayLocationY)
            };

            return sharedPicture;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="sharedPicture">ShpiEntry.</param>
        internal static SharedPictureEntity ToEntity(this SharedPicture sharedPicture)
        {
            SharedPictureEntity sharedPictureEntity = new SharedPictureEntity
            {
                BitmapWidth = sharedPicture.BitmapSize.Width,
                BitmapHeight = sharedPicture.BitmapSize.Height,
                DisplayLocationX = sharedPicture.DisplayLocation.X,
                DisplayLocationY = sharedPicture.DisplayLocation.Y
            };

            return sharedPictureEntity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="sharedPictureEntities">ShpiEntry entities.</param>
        internal static IEnumerable<SharedPicture> ToDomainModels(this IEnumerable<SharedPictureEntity> sharedPictureEntities)
        {
            IEnumerable<SharedPicture> sharedPictures = sharedPictureEntities.Select(sharedPictureEntity => sharedPictureEntity.ToDomainModel());

            return sharedPictures;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="sharedPictures">ShpiEntries.</param>
        internal static IEnumerable<SharedPictureEntity> ToEntities(this IEnumerable<SharedPicture> sharedPictures)
        {
            IEnumerable<SharedPictureEntity> sharedPictureEntities = sharedPictures.Select(sharedPicture => sharedPicture.ToEntity());

            return sharedPictureEntities;
        }
    }
}
