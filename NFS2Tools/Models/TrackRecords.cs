using System.Collections.Generic;

namespace NFS2Tools.Models
{
    /// <summary>
    /// Track statistics data.
    /// </summary>
    public class TrackRecords
    {
        /// <summary>
        /// Gets or sets the best lap record.
        /// </summary>
        /// <value>The lap records.</value>
        public LapRecord BestLapRecord { get; set; }

        /// <summary>
        /// Gets or sets the records for 2-lap races.
        /// </summary>
        /// <value>The lap records.</value>
        public List<LapRecord> RecordsFor2Laps { get; set; }

        /// <summary>
        /// Gets or sets the records for 4-lap races.
        /// </summary>
        /// <value>The lap records.</value>
        public List<LapRecord> RecordsFor4Laps { get; set; }

        /// <summary>
        /// Gets or sets the records for 8-lap races.
        /// </summary>
        /// <value>The lap records.</value>
        public List<LapRecord> RecordsFor8Laps { get; set; }
    }
}
