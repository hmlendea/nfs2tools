using System.IO;

using NFS2Tools.DataAccess.DataObjects;

namespace NFS2Tools.DataAccess.IO
{
    /// <summary>
    /// STF manager.
    /// </summary>
    public class StatsFile : IStatsFile
    {
        /// <summary>
        /// Reads the STF file.
        /// </summary>
        /// <returns>The statistics.</returns>
        /// <param name="path">Path.</param>
        public TrackRecordsEntity Read(string path)
        {
            TrackRecordsEntity trackRecordEntity = new();

            using NfsFileReader reader = new(path, FileMode.Open);
            reader.ReaderEndianness = Endianness.BigEndian;

            trackRecordEntity.LapRecords = new LapRecordEntity[31];

            for (int i = 0; i < 31; i++)
            {
                LapRecordEntity record = new()
                {
                    PlayerName = reader.ReadString(9),
                    CarId = (short)(reader.ReadInt16() & 0x00FF),
                    Time = reader.ReadInt32(Endianness.LittleEndian),
                    RaceType = reader.ReadInt16()
                };
                reader.ReadBytes(3);

                // Clean the name
                int endIndex = record.PlayerName.IndexOf('\0');
                if (endIndex > 0)
                {
                    record.PlayerName = record.PlayerName[..endIndex];
                }
                record.PlayerName = record.PlayerName.Replace("\t", "");

                trackRecordEntity.LapRecords[i] = record;
            }

            return trackRecordEntity;
        }

        /// <summary>
        /// Writes the STF file.
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="statsFileEntity">Stats file entity.</param>
        public void Write(string path, TrackRecordsEntity statsFileEntity)
        {
            using NfsFileWriter writer = new(path, FileMode.OpenOrCreate);
            writer.WriterEndianness = Endianness.BigEndian;

            for (int i = 0; i < 31; i++)
            {
                LapRecordEntity record = statsFileEntity.LapRecords[i];

                writer.WriteString(record.PlayerName, 8, '\t');
                writer.WriteInt16(record.CarId);
                writer.WriteInt32(record.Time, Endianness.LittleEndian);
                writer.WriteInt16(record.RaceType);
                writer.WriteBytes([0, 0, 0]);
            }
        }
    }
}
