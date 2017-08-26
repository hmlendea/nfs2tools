namespace NFS2Tools.DataAccess.DataObjects
{
    /// <summary>
    /// Stats file (STF) data entity.
    /// </summary>
    public class TrackRecordsEntity
    {
        /// <summary>
        /// Gets or sets the lap records.
        /// </summary>
        /// <value>The lap records.</value>
        public LapRecordEntity[] LapRecords { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackRecordsEntity"/> class.
        /// </summary>
        public TrackRecordsEntity()
        {
            LapRecords = new LapRecordEntity[31];
        }
    }
}
