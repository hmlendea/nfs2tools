using System.Drawing;

namespace NFS2Tools.Models
{
    /// <summary>
    /// Shared picture (SHPI entry).
    /// </summary>
    public class SharedPicture
    {
        /// <summary>
        /// Gets the size of the block.
        /// </summary>
        /// <value>The size of the block.</value>
        public int BlockSize => BitmapSize.Width * BitmapSize.Height + 16;

        /// <summary>
        /// Gets or sets the size of the bitmap.
        /// </summary>
        /// <value>The size in pixels of the bitmap.</value>
        public Size BitmapSize { get; set; }

        /// <summary>
        /// Gets or sets the display location.
        /// </summary>
        /// <value>The location at which the bitmap will be displayed.</value>
        public Point DisplayLocation { get; set; }

        // TODO: BitmapData property
    }
}
