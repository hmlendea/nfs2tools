namespace NFS2Tools.DataAccess.DataObjects
{
    /// <summary>
    /// Stats file (STF) data entity.
    /// </summary>
    public class TrackRecordsEntity
    {
        /// <summary>
        /// Gets or sets the lap reords.
        /// </summary>
        /// <value>The lap records.</value>
        public LapRecordEntity[] LapRecords { get; set; }
    }
}
