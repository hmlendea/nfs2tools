using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// Lap record mapping extensions for converting between entities and domain models.
    /// </summary>
    static class SharedPictureFileMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="sharedPictureFileEntity">Shpi entity.</param>
        internal static SharedPictureFile ToDomainModel(this SharedPictureFileEntity sharedPictureFileEntity)
        {
            SharedPictureFile sharedPictureFile = new SharedPictureFile
            {
                FileLength = sharedPictureFileEntity.FileLength,
                ObjectsCount = sharedPictureFileEntity.ObjectsCount,
                DirectoryId = sharedPictureFileEntity.DirectoryId
            };

            return sharedPictureFile;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="sharedPictureFile">Shpi.</param>
        internal static SharedPictureFileEntity ToEntity(this SharedPictureFile sharedPictureFile)
        {
            SharedPictureFileEntity sharedPictureFileEntity = new SharedPictureFileEntity
            {
                FileLength = sharedPictureFile.FileLength,
                ObjectsCount = sharedPictureFile.ObjectsCount,
                DirectoryId = sharedPictureFile.DirectoryId
            };

            return sharedPictureFileEntity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="sharedPictureFileEntities">Shpi entities.</param>
        internal static IEnumerable<SharedPictureFile> ToDomainModels(this IEnumerable<SharedPictureFileEntity> sharedPictureFileEntities)
        {
            IEnumerable<SharedPictureFile> sharedPictureFiles = sharedPictureFileEntities.Select(sharedPictureFileEntity => sharedPictureFileEntity.ToDomainModel());

            return sharedPictureFiles;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="sharedPictureFiles">Shpis.</param>
        internal static IEnumerable<SharedPictureFileEntity> ToEntities(this IEnumerable<SharedPictureFile> sharedPictureFiles)
        {
            IEnumerable<SharedPictureFileEntity> sharedPictureFileEntities = sharedPictureFiles.Select(sharedPictureFile => sharedPictureFile.ToEntity());

            return sharedPictureFileEntities;
        }
    }
}
