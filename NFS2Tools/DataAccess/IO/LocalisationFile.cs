using System.Collections.Generic;
using System.IO;

using NFS2Tools.DataAccess.DataObjects;

namespace NFS2Tools.DataAccess.IO
{
    /// <summary>
    /// Language file.
    /// </summary>
    public class LocalisationFile
    {
        int firstValueOffset;

        /// <summary>
        /// Reads the localisation file.
        /// </summary>
        /// <returns>The localisation data.</returns>
        /// <param name="path">Path.</param>
        public LocalisationEntity Read(string path)
        {
            LocalisationEntity locale = new LocalisationEntity();

            using (NfsFileReader reader = new NfsFileReader(path, FileMode.Open))
            {
                locale.Entries = new List<LocalisationEntryEntity>();
                locale.Unknown1 = reader.ReadBytes(8);

                firstValueOffset = int.MaxValue;

                while (reader.BaseStream.Position < firstValueOffset - 12)
                {
                    LocalisationEntryEntity entry = new LocalisationEntryEntity();
                    entry.Offset = reader.ReadInt32();
                    entry.UnknownBytes = reader.ReadBytes(8);

                    locale.Entries.Add(entry);

                    if (entry.Offset < firstValueOffset)
                    {
                        firstValueOffset = entry.Offset;
                    }
                }

                locale.Unknown2 = reader.ReadBytes((int)(firstValueOffset - reader.BaseStream.Position));

                for (int i = 0; i < locale.Entries.Count; i++)
                {
                    if (i < locale.Entries.Count - 1)
                    {
                        int length = locale.Entries[i + 1].Offset - locale.Entries[i].Offset - 1;
                        locale.Entries[i].Value = reader.ReadString(length + 1);
                    }
                    else
                    {
                        locale.Entries[i].Value = reader.ReadString();
                    }
                }

                locale.Unknown3 = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
            }

            return locale;
        }

        public void Write(string path, LocalisationEntity locale)
        {
            CalculateEntryOffsets(locale);

            using (NfsFileWriter writer = new NfsFileWriter(path, FileMode.OpenOrCreate))
            {
                writer.WriteBytes(locale.Unknown1);

                for (int i = 0; i < locale.Entries.Count; i++)
                {
                    LocalisationEntryEntity entry = locale.Entries[i];
                    writer.WriteInt32(entry.Offset);
                    writer.WriteBytes(entry.UnknownBytes);
                }

                writer.WriteBytes(locale.Unknown2);

                for (int i = 0; i < locale.Entries.Count; i++)
                {
                    string str = locale.Entries[i].Value;
                    writer.WriteString(str);
                }

                writer.WriteBytes(locale.Unknown3);
            }
        }

        void CalculateEntryOffsets(LocalisationEntity locale)
        {
            int currentOffset = locale.Entries.Count * 12 + 12;

            for (int i = 0; i < locale.Entries.Count; i++)
            {
                locale.Entries[i].Offset = currentOffset;
                currentOffset += locale.Entries[i].Value.Length + 1;
            }
        }
    }
}
