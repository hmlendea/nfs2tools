﻿using System;
using System.IO;
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
        /// Writes the STF file.
        /// </summary>
        /// <param name="statsFileEntity">Stats file entity.</param>
        /// <param name="path">Path.</param>
        public void Write(TrackRecordsEntity statsFileEntity, string path)
        {
            throw new NotImplementedException();
        }

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
                    lapRecord.CarId = BitConverter.ToInt16(bits, currentEntryOffset + 9);
                    lapRecord.Time = BitConverter.ToInt32(bits, currentEntryOffset + 11);
                    lapRecord.RaceType = BitConverter.ToInt16(bits, currentEntryOffset + 15);

                    lapRecord.PlayerName = lapRecord.PlayerName.Substring(0, lapRecord.PlayerName.IndexOf("\0", StringComparison.InvariantCulture));

                    trackRecordEntity.LapRecords[i] = lapRecord;
                }
            }

            return trackRecordEntity;
        }
    }
}