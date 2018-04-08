using NFS2Tools.Models.Enumerations;

namespace NFS2Tools.Models
{
    /// <summary>
    /// Lap record.
    /// </summary>
    public class LapRecord
    {
        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>The name of the player.</value>
        public string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the car.
        /// </summary>
        /// <value>The car.</value>
        public CarType Car { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        public float Time { get; set; }

        /// <summary>
        /// Gets or sets the type of the race.
        /// </summary>
        /// <value>The type of the race.</value>
        public RaceType RaceType { get; set; }
    }
}
