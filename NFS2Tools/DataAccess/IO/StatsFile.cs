using System.IO;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.DataAccess.IO.Interfaces;

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
            TrackRecordsEntity trackRecordEntity = new TrackRecordsEntity();

            using (NfsFileReader reader = new NfsFileReader(path, FileMode.Open))
            {
                reader.ReaderEndianness = Endianness.BigEndian;

                trackRecordEntity.LapRecords = new LapRecordEntity[31];

                for (int i = 0; i < 31; i++)
                {
                    LapRecordEntity record = new LapRecordEntity();

                    record.PlayerName = reader.ReadString(9);
                    record.CarId = (short)(reader.ReadInt16() & 0x00FF);
                    record.Time = reader.ReadInt32(Endianness.LittleEndian);
                    record.RaceType = reader.ReadInt16();
                    reader.ReadBytes(3);

                    // Clean the name
                    int endIndex = record.PlayerName.IndexOf('\0');
                    if (endIndex > 0)
                    {
                        record.PlayerName = record.PlayerName.Substring(0, endIndex);
                    }
                    record.PlayerName = record.PlayerName.Replace("\t", "");

                    trackRecordEntity.LapRecords[i] = record;
                }
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
            using (NfsFileWriter writer = new NfsFileWriter(path, FileMode.OpenOrCreate))
            {
                writer.WriterEndianness = Endianness.BigEndian;

                for (int i = 0; i < 31; i++)
                {
                    LapRecordEntity record = statsFileEntity.LapRecords[i];

                    writer.WriteString(record.PlayerName, 8, '\t');
                    writer.WriteInt16(record.CarId);
                    writer.WriteInt32(record.Time, Endianness.LittleEndian);
                    writer.WriteInt16(record.RaceType);
                    writer.WriteBytes(new byte[] { 0, 0, 0 });
                }
            }
        }
    }
}
