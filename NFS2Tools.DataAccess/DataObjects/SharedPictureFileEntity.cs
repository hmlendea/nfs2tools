namespace NFS2Tools.DataAccess.DataObjects
{
    public class SharedPictureFileEntity
    {
        /// <summary>
        /// Gets the SHPI header.
        /// </summary>
        /// <value>The header.</value>
        public string Header => "SHPI";

        /// <summary>
        /// Gets or sets the length of the file.
        /// </summary>
        /// <value>The length of the file in bytes.</value>
        public int FileLength { get; set; }

        /// <summary>
        /// Gets or sets the objects count.
        /// </summary>
        /// <value>The objects count.</value>
        public int ObjectsCount { get; set; }

        /// <summary>
        /// Gets or sets the directory identifier.
        /// </summary>
        /// <value>The directory identifier.</value>
        public string DirectoryId { get; set; }
    }
}
