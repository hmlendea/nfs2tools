using System.IO;

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

            using (NfsFileReader reader = new NfsFileReader(path, FileMode.Open))
            {
                locale.Unknown1 = reader.ReadBytes(offsetUnknown1End);

                locale.GameSetup = reader.ReadString();
                locale.Location = reader.ReadString();
                locale.PlayerOneSmall = reader.ReadString();
                locale.PlayerTwoSmall = reader.ReadString();
                locale.Opponents = reader.ReadString();
                locale.StartRace = reader.ReadString();
                locale.ConnectBig = reader.ReadString();
                locale.Options = reader.ReadString();
                locale.Exit = reader.ReadString();
                locale.GameType = reader.ReadString();
                locale.RaceType = reader.ReadString();
                locale.Style = reader.ReadString();
                locale.CatchUp = reader.ReadString();
                locale.Backwards = reader.ReadString();
                locale.Mirrored = reader.ReadString();
                locale.NavigationDone = reader.ReadString();
                locale.NavigationCancel = reader.ReadString();
                locale.OnePlayer = reader.ReadString();
                locale.SplitScreen = reader.ReadString();
                locale.ModemSmall = reader.ReadString();
                locale.SerialLinkSmall = reader.ReadString();
                locale.NetworkSmall = reader.ReadString();
                locale.SingleRace = reader.ReadString();
                locale.Tournament = reader.ReadString();
                locale.Knockout = reader.ReadString();
                locale.Simulation = reader.ReadString();
                locale.Arcade = reader.ReadString();
                locale.Wild = reader.ReadString();
                locale.Beginner = reader.ReadString();
                locale.Advanced = reader.ReadString();
                locale.SimulationShort = reader.ReadString();
                locale.ArcadeShort = reader.ReadString();
                locale.SerialLinkBig = reader.ReadString();
                locale.ComPort = reader.ReadString();
                locale.ConnectSmall = reader.ReadString();
                locale.CancelSmall = reader.ReadString();
                locale.Nr1 = reader.ReadString();
                locale.Nr2 = reader.ReadString();
                locale.Nr3 = reader.ReadString();
                locale.Nr4 = reader.ReadString();
                locale.ModemBig = reader.ReadString();
                locale.ModemSmall2 = reader.ReadString();
                locale.PhoneList = reader.ReadString();
                locale.DeleteNumber = reader.ReadString();
                locale.Dial = reader.ReadString();
                locale.Answer = reader.ReadString();
                locale.CancelBig2 = reader.ReadString();
                locale.NetworkBig = reader.ReadString();
                locale.Colour = reader.ReadString();
                locale.Protocol = reader.ReadString();
                locale.Players = reader.ReadString();
                locale.CreateGame = reader.ReadString();
                locale.JoinGame = reader.ReadString();
                locale.NoGamesAvailable = reader.ReadString();
                locale.TwoPeerToPeer = reader.ReadString();
                locale.TwoEightClientServer = reader.ReadString();
                locale.CancelBig512 = reader.ReadString();
                locale.Track = reader.ReadString();
                locale.Laps = reader.ReadString();
                locale.TrackInfo = reader.ReadString();
                locale.TrackRecords = reader.ReadString();
                locale.PersonalStatistics = reader.ReadString();
                locale.DoneBig821 = reader.ReadString();
                locale.CancelBig716 = reader.ReadString();
                locale.Track00Name = reader.ReadString();
                locale.Track02Name = reader.ReadString();
                locale.Track03Name = reader.ReadString();
                locale.Track04Name = reader.ReadString();
                locale.Track05Name = reader.ReadString();
                locale.Track06Name = reader.ReadString();
                locale.Track07Name = reader.ReadString();
                locale.Track08Name = reader.ReadString();
                locale.LapsCount4 = reader.ReadString();
                locale.LapsCount8 = reader.ReadString();
                locale.LapsCount2 = reader.ReadString();
                locale.PlayerOneBig = reader.ReadString();
                locale.PlayerTwoBig = reader.ReadString();
                locale.Car = reader.ReadString();
                locale.Transmission = reader.ReadString();
                locale.Colour218 = reader.ReadString();
                locale.Graph = reader.ReadString();
                locale.Settings = reader.ReadString();
                locale.Showcase = reader.ReadString();
                locale.SlotCar = reader.ReadString();
                locale.DoneBig617 = reader.ReadString();
                locale.DoneBig918 = reader.ReadString();
                locale.CancelBig816 = reader.ReadString();
                locale.CancelBig168 = reader.ReadString();
                locale.Acceleration = reader.ReadString();
                locale.TopSpeed = reader.ReadString();
                locale.Breaking = reader.ReadString();
                locale.Handling = reader.ReadString();
                locale.Yes186 = reader.ReadString();
                locale.No195 = reader.ReadString();
                locale.Automatic = reader.ReadString();
                locale.Manual = reader.ReadString();
                locale.Car00Name = reader.ReadString();
                locale.Car01Name = reader.ReadString();
                locale.Car02Name = reader.ReadString();
                locale.Car03Name = reader.ReadString();
                locale.Car04Name = reader.ReadString();
                locale.Car05Name = reader.ReadString();
                locale.Car06Name = reader.ReadString();
                locale.Car07Name = reader.ReadString();
                locale.Car08Name = reader.ReadString();
                locale.Car09Name = reader.ReadString();
                locale.Car10Name = reader.ReadString();
                locale.Car11Name = reader.ReadString();
                locale.Car12Name = reader.ReadString();
                locale.Car13Name = reader.ReadString();
                locale.Car14Name = reader.ReadString();

                locale.Unknown2 = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
            }

            return locale;
        }

        public void Write(string path, LocalisationEntity locale)
        {
            using (NfsFileWriter writer = new NfsFileWriter(path, FileMode.OpenOrCreate))
            {
                writer.WriteBytes(locale.Unknown1);

                writer.WriteString(locale.GameSetup);
                writer.WriteString(locale.Location);
                writer.WriteString(locale.PlayerOneSmall);
                writer.WriteString(locale.PlayerTwoSmall);
                writer.WriteString(locale.Opponents);
                writer.WriteString(locale.StartRace);
                writer.WriteString(locale.ConnectBig);
                writer.WriteString(locale.Options);
                writer.WriteString(locale.Exit);
                writer.WriteString(locale.GameType);
                writer.WriteString(locale.RaceType);
                writer.WriteString(locale.Style);
                writer.WriteString(locale.CatchUp);
                writer.WriteString(locale.Backwards);
                writer.WriteString(locale.Mirrored);
                writer.WriteString(locale.NavigationDone);
                writer.WriteString(locale.NavigationCancel);
                writer.WriteString(locale.OnePlayer);
                writer.WriteString(locale.SplitScreen);
                writer.WriteString(locale.ModemSmall);
                writer.WriteString(locale.SerialLinkSmall);
                writer.WriteString(locale.NetworkSmall);
                writer.WriteString(locale.SingleRace);
                writer.WriteString(locale.Tournament);
                writer.WriteString(locale.Knockout);
                writer.WriteString(locale.Simulation);
                writer.WriteString(locale.Arcade);
                writer.WriteString(locale.Wild);
                writer.WriteString(locale.Beginner);
                writer.WriteString(locale.Advanced);
                writer.WriteString(locale.SimulationShort);
                writer.WriteString(locale.ArcadeShort);
                writer.WriteString(locale.SerialLinkBig);
                writer.WriteString(locale.ComPort);
                writer.WriteString(locale.ConnectSmall);
                writer.WriteString(locale.CancelSmall);
                writer.WriteString(locale.Nr1);
                writer.WriteString(locale.Nr2);
                writer.WriteString(locale.Nr3);
                writer.WriteString(locale.Nr4);
                writer.WriteString(locale.ModemBig);
                writer.WriteString(locale.ModemSmall2);
                writer.WriteString(locale.PhoneList);
                writer.WriteString(locale.DeleteNumber);
                writer.WriteString(locale.Dial);
                writer.WriteString(locale.Answer);
                writer.WriteString(locale.CancelBig2);
                writer.WriteString(locale.NetworkBig);
                writer.WriteString(locale.Colour);
                writer.WriteString(locale.Protocol);
                writer.WriteString(locale.Players);
                writer.WriteString(locale.CreateGame);
                writer.WriteString(locale.JoinGame);
                writer.WriteString(locale.NoGamesAvailable);
                writer.WriteString(locale.TwoPeerToPeer);
                writer.WriteString(locale.TwoEightClientServer);
                writer.WriteString(locale.CancelBig512);
                writer.WriteString(locale.Track);
                writer.WriteString(locale.Laps);
                writer.WriteString(locale.TrackInfo);
                writer.WriteString(locale.TrackRecords);
                writer.WriteString(locale.PersonalStatistics);
                writer.WriteString(locale.DoneBig821);
                writer.WriteString(locale.CancelBig716);
                writer.WriteString(locale.Track00Name);
                writer.WriteString(locale.Track02Name);
                writer.WriteString(locale.Track03Name);
                writer.WriteString(locale.Track04Name);
                writer.WriteString(locale.Track05Name);
                writer.WriteString(locale.Track06Name);
                writer.WriteString(locale.Track07Name);
                writer.WriteString(locale.Track08Name);
                writer.WriteString(locale.LapsCount4);
                writer.WriteString(locale.LapsCount8);
                writer.WriteString(locale.LapsCount2);
                writer.WriteString(locale.PlayerOneBig);
                writer.WriteString(locale.PlayerTwoBig);
                writer.WriteString(locale.Car);
                writer.WriteString(locale.Transmission);
                writer.WriteString(locale.Colour218);
                writer.WriteString(locale.Graph);
                writer.WriteString(locale.Settings);
                writer.WriteString(locale.Showcase);
                writer.WriteString(locale.SlotCar);
                writer.WriteString(locale.DoneBig617);
                writer.WriteString(locale.DoneBig918);
                writer.WriteString(locale.CancelBig816);
                writer.WriteString(locale.CancelBig168);
                writer.WriteString(locale.Acceleration);
                writer.WriteString(locale.TopSpeed);
                writer.WriteString(locale.Breaking);
                writer.WriteString(locale.Handling);
                writer.WriteString(locale.Yes186);
                writer.WriteString(locale.No195);
                writer.WriteString(locale.Automatic);
                writer.WriteString(locale.Manual);
                writer.WriteString(locale.Car00Name);
                writer.WriteString(locale.Car01Name);
                writer.WriteString(locale.Car02Name);
                writer.WriteString(locale.Car03Name);
                writer.WriteString(locale.Car04Name);
                writer.WriteString(locale.Car05Name);
                writer.WriteString(locale.Car06Name);
                writer.WriteString(locale.Car07Name);
                writer.WriteString(locale.Car08Name);
                writer.WriteString(locale.Car09Name);
                writer.WriteString(locale.Car10Name);
                writer.WriteString(locale.Car11Name);
                writer.WriteString(locale.Car12Name);
                writer.WriteString(locale.Car13Name);
                writer.WriteString(locale.Car14Name);

                writer.WriteBytes(locale.Unknown2);
            }
        }
    }
}
