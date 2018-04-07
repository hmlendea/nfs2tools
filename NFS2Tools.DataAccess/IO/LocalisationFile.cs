using System;
using System.IO;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;

namespace NFS2Tools.DataAccess.IO
{
    /// <summary>
    /// Language file.
    /// </summary>
    public class LocalisationFile
    {
        /// <summary>
        /// Reads the STF file.
        /// </summary>
        /// <returns>The stf.</returns>
        /// <param name="path">Path.</param>
        public LocalisationEntity Read(string path)
        {
            int offsetUnknown1End = 0x4668;

            LocalisationEntity locale = new LocalisationEntity();

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                locale.Unknown1 = reader.ReadBytes(offsetUnknown1End);

                locale.GameSetup = ReadString(reader);
                locale.Location = ReadString(reader);
                locale.PlayerOneSmall = ReadString(reader);
                locale.PlayerTwoSmall = ReadString(reader);
                locale.Opponents = ReadString(reader);
                locale.StartRace = ReadString(reader);
                locale.ConnectBig = ReadString(reader);
                locale.Options = ReadString(reader);
                locale.Exit = ReadString(reader);
                locale.GameType = ReadString(reader);
                locale.RaceType = ReadString(reader);
                locale.Style = ReadString(reader);
                locale.CatchUp = ReadString(reader);
                locale.Backwards = ReadString(reader);
                locale.Mirrored = ReadString(reader);
                locale.NavigationDone = ReadString(reader);
                locale.NavigationCancel = ReadString(reader);
                locale.OnePlayer = ReadString(reader);
                locale.SplitScreen = ReadString(reader);
                locale.ModemSmall = ReadString(reader);
                locale.SerialLinkSmall = ReadString(reader);
                locale.NetworkSmall = ReadString(reader);
                locale.SingleRace = ReadString(reader);
                locale.Tournament = ReadString(reader);
                locale.Knockout = ReadString(reader);
                locale.Simulation = ReadString(reader);
                locale.Arcade = ReadString(reader);
                locale.Wild = ReadString(reader);
                locale.Beginner = ReadString(reader);
                locale.Advanced = ReadString(reader);
                locale.SimulationShort = ReadString(reader);
                locale.ArcadeShort = ReadString(reader);
                locale.SerialLinkBig = ReadString(reader);
                locale.ComPort = ReadString(reader);
                locale.ConnectSmall = ReadString(reader);
                locale.CancelSmall = ReadString(reader);
                locale.Nr1 = ReadString(reader);
                locale.Nr2 = ReadString(reader);
                locale.Nr3 = ReadString(reader);
                locale.Nr4 = ReadString(reader);
                locale.ModemBig = ReadString(reader);
                locale.ModemSmall2 = ReadString(reader);
                locale.PhoneList = ReadString(reader);
                locale.DeleteNumber = ReadString(reader);
                locale.Dial = ReadString(reader);
                locale.Answer = ReadString(reader);
                locale.CancelBig2 = ReadString(reader);
                locale.NetworkBig = ReadString(reader);
                locale.Colour = ReadString(reader);
                locale.Protocol = ReadString(reader);
                locale.Players = ReadString(reader);
                locale.CreateGame = ReadString(reader);
                locale.JoinGame = ReadString(reader);
                locale.NoGamesAvailable = ReadString(reader);
                locale.TwoPeerToPeer = ReadString(reader);
                locale.TwoEightClientServer = ReadString(reader);
                locale.CancelBig512 = ReadString(reader);
                locale.Track = ReadString(reader);
                locale.Laps = ReadString(reader);
                locale.TrackInfo = ReadString(reader);
                locale.TrackRecords = ReadString(reader);
                locale.PersonalStatistics = ReadString(reader);
                locale.DoneBig821 = ReadString(reader);
                locale.CancelBig716 = ReadString(reader);
                locale.Track00Name = ReadString(reader);
                locale.Track02Name = ReadString(reader);
                locale.Track03Name = ReadString(reader);
                locale.Track04Name = ReadString(reader);
                locale.Track05Name = ReadString(reader);
                locale.Track06Name = ReadString(reader);
                locale.Track07Name = ReadString(reader);
                locale.Track08Name = ReadString(reader);
                locale.LapsCount4 = ReadString(reader);
                locale.LapsCount8 = ReadString(reader);
                locale.LapsCount2 = ReadString(reader);
                locale.PlayerOneBig = ReadString(reader);
                locale.PlayerTwoBig = ReadString(reader);
                locale.Car = ReadString(reader);
                locale.Transmission = ReadString(reader);
                locale.Colour218 = ReadString(reader);
                locale.Graph = ReadString(reader);
                locale.Settings = ReadString(reader);
                locale.Showcase = ReadString(reader);
                locale.SlotCar = ReadString(reader);
                locale.DoneBig617 = ReadString(reader);
                locale.DoneBig918 = ReadString(reader);
                locale.CancelBig816 = ReadString(reader);
                locale.CancelBig168 = ReadString(reader);
                locale.Acceleration = ReadString(reader);
                locale.TopSpeed = ReadString(reader);
                locale.Breaking = ReadString(reader);
                locale.Handling = ReadString(reader);
                locale.Yes186 = ReadString(reader);
                locale.No195 = ReadString(reader);
                locale.Automatic = ReadString(reader);
                locale.Manual = ReadString(reader);
                locale.Car00Name = ReadString(reader);
                locale.Car01Name = ReadString(reader);
                locale.Car02Name = ReadString(reader);
                locale.Car03Name = ReadString(reader);
                locale.Car04Name = ReadString(reader);
                locale.Car05Name = ReadString(reader);
                locale.Car06Name = ReadString(reader);
                locale.Car07Name = ReadString(reader);
                locale.Car08Name = ReadString(reader);
                locale.Car09Name = ReadString(reader);
                locale.Car10Name = ReadString(reader);
                locale.Car11Name = ReadString(reader);
                locale.Car12Name = ReadString(reader);
                locale.Car13Name = ReadString(reader);
                locale.Car14Name = ReadString(reader);

                locale.Unknown2 = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
            }

            return locale;
        }

        public void Write(string path, LocalisationEntity locale)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(locale.Unknown1);

                WriteString(writer, locale.GameSetup);
                WriteString(writer, locale.Location);
                WriteString(writer, locale.PlayerOneSmall);
                WriteString(writer, locale.PlayerTwoSmall);
                WriteString(writer, locale.Opponents);
                WriteString(writer, locale.StartRace);
                WriteString(writer, locale.ConnectBig);
                WriteString(writer, locale.Options);
                WriteString(writer, locale.Exit);
                WriteString(writer, locale.GameType);
                WriteString(writer, locale.RaceType);
                WriteString(writer, locale.Style);
                WriteString(writer, locale.CatchUp);
                WriteString(writer, locale.Backwards);
                WriteString(writer, locale.Mirrored);
                WriteString(writer, locale.NavigationDone);
                WriteString(writer, locale.NavigationCancel);
                WriteString(writer, locale.OnePlayer);
                WriteString(writer, locale.SplitScreen);
                WriteString(writer, locale.ModemSmall);
                WriteString(writer, locale.SerialLinkSmall);
                WriteString(writer, locale.NetworkSmall);
                WriteString(writer, locale.SingleRace);
                WriteString(writer, locale.Tournament);
                WriteString(writer, locale.Knockout);
                WriteString(writer, locale.Simulation);
                WriteString(writer, locale.Arcade);
                WriteString(writer, locale.Wild);
                WriteString(writer, locale.Beginner);
                WriteString(writer, locale.Advanced);
                WriteString(writer, locale.SimulationShort);
                WriteString(writer, locale.ArcadeShort);
                WriteString(writer, locale.SerialLinkBig);
                WriteString(writer, locale.ComPort);
                WriteString(writer, locale.ConnectSmall);
                WriteString(writer, locale.CancelSmall);
                WriteString(writer, locale.Nr1);
                WriteString(writer, locale.Nr2);
                WriteString(writer, locale.Nr3);
                WriteString(writer, locale.Nr4);
                WriteString(writer, locale.ModemBig);
                WriteString(writer, locale.ModemSmall2);
                WriteString(writer, locale.PhoneList);
                WriteString(writer, locale.DeleteNumber);
                WriteString(writer, locale.Dial);
                WriteString(writer, locale.Answer);
                WriteString(writer, locale.CancelBig2);
                WriteString(writer, locale.NetworkBig);
                WriteString(writer, locale.Colour);
                WriteString(writer, locale.Protocol);
                WriteString(writer, locale.Players);
                WriteString(writer, locale.CreateGame);
                WriteString(writer, locale.JoinGame);
                WriteString(writer, locale.NoGamesAvailable);
                WriteString(writer, locale.TwoPeerToPeer);
                WriteString(writer, locale.TwoEightClientServer);
                WriteString(writer, locale.CancelBig512);
                WriteString(writer, locale.Track);
                WriteString(writer, locale.Laps);
                WriteString(writer, locale.TrackInfo);
                WriteString(writer, locale.TrackRecords);
                WriteString(writer, locale.PersonalStatistics);
                WriteString(writer, locale.DoneBig821);
                WriteString(writer, locale.CancelBig716);
                WriteString(writer, locale.Track00Name);
                WriteString(writer, locale.Track02Name);
                WriteString(writer, locale.Track03Name);
                WriteString(writer, locale.Track04Name);
                WriteString(writer, locale.Track05Name);
                WriteString(writer, locale.Track06Name);
                WriteString(writer, locale.Track07Name);
                WriteString(writer, locale.Track08Name);
                WriteString(writer, locale.LapsCount4);
                WriteString(writer, locale.LapsCount8);
                WriteString(writer, locale.LapsCount2);
                WriteString(writer, locale.PlayerOneBig);
                WriteString(writer, locale.PlayerTwoBig);
                WriteString(writer, locale.Car);
                WriteString(writer, locale.Transmission);
                WriteString(writer, locale.Colour218);
                WriteString(writer, locale.Graph);
                WriteString(writer, locale.Settings);
                WriteString(writer, locale.Showcase);
                WriteString(writer, locale.SlotCar);
                WriteString(writer, locale.DoneBig617);
                WriteString(writer, locale.DoneBig918);
                WriteString(writer, locale.CancelBig816);
                WriteString(writer, locale.CancelBig168);
                WriteString(writer, locale.Acceleration);
                WriteString(writer, locale.TopSpeed);
                WriteString(writer, locale.Breaking);
                WriteString(writer, locale.Handling);
                WriteString(writer, locale.Yes186);
                WriteString(writer, locale.No195);
                WriteString(writer, locale.Automatic);
                WriteString(writer, locale.Manual);
                WriteString(writer, locale.Car00Name);
                WriteString(writer, locale.Car01Name);
                WriteString(writer, locale.Car02Name);
                WriteString(writer, locale.Car03Name);
                WriteString(writer, locale.Car04Name);
                WriteString(writer, locale.Car05Name);
                WriteString(writer, locale.Car06Name);
                WriteString(writer, locale.Car07Name);
                WriteString(writer, locale.Car08Name);
                WriteString(writer, locale.Car09Name);
                WriteString(writer, locale.Car10Name);
                WriteString(writer, locale.Car11Name);
                WriteString(writer, locale.Car12Name);
                WriteString(writer, locale.Car13Name);
                WriteString(writer, locale.Car14Name);

                writer.Write(locale.Unknown2);
            }
        }

        string ReadString(BinaryReader reader)
        {
            string str = string.Empty;

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                char c = reader.ReadChar();

                if (c == '\0')
                {
                    return str;
                }

                str += c;
            }

            return str;
        }

        void WriteString(BinaryWriter writer, string str)
        {
            byte[] strBytes = str.Select(Convert.ToByte).ToArray();

            writer.Write(strBytes);
            writer.Write('\0');
        }
    }
}
