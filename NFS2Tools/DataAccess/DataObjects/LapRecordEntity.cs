namespace NFS2Tools.DataAccess.DataObjects
{
    /// <summary>
    /// Lap record data entity.
    /// </summary>
    public class LapRecordEntity
    {
        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>The name of the player.</value>
        public string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the car identifier.
        /// </summary>
        /// <value>The car identifier.</value>
        public short CarId { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time (64ths of a second).</value>
        public int Time { get; set; }

        /// <summary>
        /// Gets or sets the type of the race.
        /// </summary>
        /// <value>The type of the race.</value>
        public short RaceType { get; set; }
    }
}
