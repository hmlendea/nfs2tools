using System;
using System.IO;
using System.Linq;
using System.Text;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.DataAccess.IO.Interfaces;

namespace NFS2Tools.DataAccess.IO
{
    /// <summary>
    /// STF manager.
    /// </summary>
    public class StfManager : IStfManager
    {
        /// <summary>
        /// Reads the STF file.
        /// </summary>
        /// <returns>The stf.</returns>
        /// <param name="path">Path.</param>
        public TrackRecordsEntity Read(string path)
        {
            TrackRecordsEntity trackRecordEntity = new TrackRecordsEntity();

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                int length = (int)fs.Length;
                byte[] bits = new byte[length];

                fs.Read(bits, 0, length);

                for (int i = 0; i < 31; i++)
                {
                    LapRecordEntity lapRecord = new LapRecordEntity();
                    int currentEntryOffset = i * 20; // Each entry is actually 17 bytes but there seem to be 3 spare bytes for each

                    lapRecord.PlayerName = Encoding.ASCII.GetString(bits, currentEntryOffset, 9);
                    lapRecord.CarId = bits[currentEntryOffset + 10];
                    lapRecord.Time = BitConverter.ToInt32(bits, currentEntryOffset + 11);
                    lapRecord.RaceType = bits[currentEntryOffset + 16];

                    lapRecord.PlayerName = lapRecord.PlayerName.Substring(0, lapRecord.PlayerName.IndexOf("\0", StringComparison.InvariantCulture));

                    trackRecordEntity.LapRecords[i] = lapRecord;
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
            byte[] data = new byte[620];

            for (int i = 0; i < 31; i++)
            {
                LapRecordEntity lapRecord = statsFileEntity.LapRecords[i];
                int currentEntryOffset = i * 20; // Each entry is actually 17 bytes but there seem to be 3 spare bytes for each

                byte[] playerNameBytes = lapRecord.PlayerName.PadRight(9, '\0').Select(Convert.ToByte).ToArray();
                byte[] carBytes = BitConverter.GetBytes(lapRecord.CarId);
                byte[] timeBytes = BitConverter.GetBytes(lapRecord.Time);
                byte[] raceTypeBytes = BitConverter.GetBytes(lapRecord.RaceType);
                byte[] spares = { 0, 0, 0 };

                Array.Reverse(carBytes);
                Array.Reverse(raceTypeBytes);

                Array.Copy(playerNameBytes, 0, data, currentEntryOffset, playerNameBytes.Length);
                Array.Copy(carBytes, 0, data, currentEntryOffset + 9, 2);
                Array.Copy(timeBytes, 0, data, currentEntryOffset + 11, timeBytes.Length);
                Array.Copy(raceTypeBytes, 0, data, currentEntryOffset + 15, raceTypeBytes.Length);
                Array.Copy(spares, 0, data, currentEntryOffset + 17, spares.Length);
            }

            File.WriteAllBytes(path, data);
        }
    }
}
