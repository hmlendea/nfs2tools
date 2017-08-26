namespace NFS2Tools.DataAccess.DataObjects
{
    public class ShpiEntryEntity
    {
        /// <summary>
        /// Gets or sets the width of the bitmap.
        /// </summary>
        /// <value>The width of the bitmap.</value>
        public int BitmapWidth { get; set; }

        /// <summary>
        /// Gets or sets the height of the bitmap.
        /// </summary>
        /// <value>The height of the bitmap.</value>
        public int BitmapHeight { get; set; }

        /// <summary>
        /// Gets or sets the display location x.
        /// </summary>
        /// <value>The display location x.</value>
        public int DisplayLocationX { get; set; }

        /// <summary>
        /// Gets or sets the display location y.
        /// </summary>
        /// <value>The display location y.</value>
        public int DisplayLocationY { get; set; }

        // TODO: BitmapData
    }
}
