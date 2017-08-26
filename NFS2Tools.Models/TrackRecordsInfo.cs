using System.Collections.Generic;

namespace NFS2Tools.Models
{
    /// <summary>
    /// Stats file (STF).
    /// </summary>
    public class TrackRecords
    {
        /// <summary>
        /// Gets or sets the lap records.
        /// </summary>
        /// <value>The lap records.</value>
        public IEnumerable<LapRecord> LapRecords { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackRecords"/> class.
        /// </summary>
        public TrackRecords()
        {
            LapRecords = new List<LapRecord>();
        }
    }
}
