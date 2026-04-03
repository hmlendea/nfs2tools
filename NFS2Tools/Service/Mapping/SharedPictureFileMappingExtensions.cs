using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.Service.Mapping
{
    /// <summary>
    /// SharedPictureFile mapping extensions for converting between data objects and domain models.
    /// </summary>
    static class SharedPictureFileMappingExtensions
    {
        /// <summary>
        /// Converts the data object into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="dataObject">The data object.</param>
        internal static SharedPictureFile ToDomainModel(this SharedPictureFileEntity dataObject) => new()
        {
            FileLength = dataObject.FileLength,
            ObjectsCount = dataObject.ObjectsCount,
            DirectoryId = dataObject.DirectoryId
        };

        /// <summary>
        /// Converts the domain model into a data object.
        /// </summary>
        /// <returns>The data object.</returns>
        /// <param name="domainModel">The domain model.</param>
        internal static SharedPictureFileEntity ToDataObject(this SharedPictureFile domainModel) => new()
        {
            FileLength = domainModel.FileLength,
            ObjectsCount = domainModel.ObjectsCount,
            DirectoryId = domainModel.DirectoryId
        };

        /// <summary>
        /// Converts the data objects into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="dataObjects">The data objects.</param>
        internal static IEnumerable<SharedPictureFile> ToDomainModels(this IEnumerable<SharedPictureFileEntity> dataObjects)
            => dataObjects.Select(dataObject => dataObject.ToDomainModel());

        /// <summary>
        /// Converts the domain models into data objects.
        /// </summary>
        /// <returns>The data objects.</returns>
        /// <param name="domainModels">The domain models.</param>
        internal static IEnumerable<SharedPictureFileEntity> ToDataObjects(this IEnumerable<SharedPictureFile> domainModels)
            => domainModels.Select(domainModel => domainModel.ToDataObject());
    }
}
