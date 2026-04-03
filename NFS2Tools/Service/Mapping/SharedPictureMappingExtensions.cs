using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.Service.Mapping
{
    /// <summary>
    /// SharedPicture mapping extensions for converting between data objects and domain models.
    /// </summary>
    static class SharedPictureMappingExtensions
    {
        /// <summary>
        /// Converts the data object into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="dataObject">The data object.</param>
        internal static SharedPicture ToDomainModel(this SharedPictureEntity sharedPictureEntity) => new()
        {
            BitmapSize = new Size(sharedPictureEntity.BitmapWidth, sharedPictureEntity.BitmapHeight),
            DisplayLocation = new Point(sharedPictureEntity.DisplayLocationX, sharedPictureEntity.DisplayLocationY)
        };

        /// <summary>
        /// Converts the domain model into a data object.
        /// </summary>
        /// <returns>The data object.</returns>
        /// <param name="domainModel">The domain model.</param>
        internal static SharedPictureEntity ToDataObject(this SharedPicture sharedPicture) => new()
        {
            BitmapWidth = sharedPicture.BitmapSize.Width,
            BitmapHeight = sharedPicture.BitmapSize.Height,
            DisplayLocationX = sharedPicture.DisplayLocation.X,
            DisplayLocationY = sharedPicture.DisplayLocation.Y
        };

        /// <summary>
        /// Converts the data objects into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="dataObjects">The data objects.</param>
        internal static IEnumerable<SharedPicture> ToDomainModels(this IEnumerable<SharedPictureEntity> dataObjects)
            => dataObjects.Select(dataObject => dataObject.ToDomainModel());

        /// <summary>
        /// Converts the domain models into data objects.
        /// </summary>
        /// <returns>The data objects.</returns>
        /// <param name="domainModels">The domain models.</param>
        internal static IEnumerable<SharedPictureEntity> ToDataObjects(this IEnumerable<SharedPicture> domainModels)
            => domainModels.Select(domainModel => domainModel.ToDataObject());
    }
}
