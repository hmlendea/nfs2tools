using System.Collections.Generic;
using System.Linq;

using NFS2Tools.DataAccess.DataObjects;
using NFS2Tools.Models;

namespace NFS2Tools.ConversionLogic.Mapping
{
    /// <summary>
    /// Localisation mapping extensions for converting between entities and domain models.
    /// </summary>
    static class LocalisationMappingExtensions
    {
        /// <summary>
        /// Converts the entity into a domain model.
        /// </summary>
        /// <returns>The domain model.</returns>
        /// <param name="entity">Localisation entity.</param>
        internal static Localisation ToDomainModel(this LocalisationEntity entity)
        {
            Localisation model = new Localisation
            {
                Unknown1 = entity.Unknown1,
                Unknown2 = entity.Unknown2,
                GameSetup = entity.GameSetup,
                Location = entity.Location,
                PlayerOneSmall = entity.PlayerOneSmall,
                PlayerTwoSmall = entity.PlayerOneSmall,
                Opponents = entity.PlayerOneSmall,
                StartRace = entity.PlayerOneSmall,
                ConnectBig = entity.ConnectBig,
                Options = entity.Options,
                Exit = entity.Exit,
                GameType = entity.GameType,
                RaceType = entity.RaceType,
                Style = entity.Style,
                CatchUp = entity.CatchUp,
                Backwards = entity.Backwards,
                Mirrored = entity.Mirrored,
                NavigationDone = entity.NavigationDone,
                NavigationCancel = entity.NavigationCancel,
                OnePlayer = entity.OnePlayer,
                SplitScreen = entity.SplitScreen,
                ModemSmall = entity.ModemSmall,
                SerialLinkSmall = entity.SerialLinkSmall,
                NetworkSmall = entity.NetworkSmall,
                SingleRace = entity.SingleRace,
                Tournament = entity.Tournament,
                Knockout = entity.Knockout,
                Simulation = entity.Simulation,
                Arcade = entity.Arcade,
                Wild = entity.Wild,
                Beginner = entity.Beginner,
                Advanced = entity.Advanced,
                SimulationShort = entity.SimulationShort,
                ArcadeShort = entity.ArcadeShort,
                SerialLinkBig = entity.SerialLinkBig,
                ComPort = entity.ComPort,
                ConnectSmall = entity.ConnectSmall,
                CancelSmall = entity.CancelSmall,
                Nr1 = entity.Nr1,
                Nr2 = entity.Nr2,
                Nr3 = entity.Nr3,
                Nr4 = entity.Nr4,
                ModemBig = entity.ModemBig,
                ModemSmall2 = entity.ModemSmall2,
                PhoneList = entity.PhoneList,
                DeleteNumber = entity.DeleteNumber,
                Dial = entity.Dial,
                Answer = entity.Answer,
                CancelBig2 = entity.CancelBig2,
                NetworkBig = entity.NetworkBig,
                Colour = entity.Colour,
                Protocol = entity.Protocol,
                Players = entity.Players,
                CreateGame = entity.CreateGame,
                JoinGame = entity.JoinGame,
                NoGamesAvailable = entity.NoGamesAvailable,
                TwoPeerToPeer = entity.TwoPeerToPeer,
                TwoEightClientServer = entity.TwoEightClientServer,
                CancelBig512 = entity.CancelBig512,
                Track = entity.Track,
                TrackInfo = entity.TrackInfo,
                TrackRecords = entity.TrackRecords,
                PersonalStatistics = entity.PersonalStatistics,
                DoneBig821 = entity.DoneBig821,
                CancelBig716 = entity.CancelBig716,
                Track00Name = entity.Track00Name,
                Track02Name = entity.Track02Name,
                Track03Name = entity.Track03Name,
                Track04Name = entity.Track04Name,
                Track05Name = entity.Track05Name,
                Track06Name = entity.Track06Name,
                Track07Name = entity.Track07Name,
                Track08Name = entity.Track08Name,
                LapsCount4 = entity.LapsCount4,
                LapsCount8 = entity.LapsCount8,
                LapsCount2 = entity.LapsCount2,
                PlayerOneBig = entity.PlayerOneBig,
                PlayerTwoBig = entity.PlayerTwoBig,
                Car = entity.Car,
                Transmission = entity.Transmission,
                Colour218 = entity.Colour218,
                Graph = entity.Graph,
                Settings = entity.Settings,
                Showcase = entity.Showcase,
                SlotCar = entity.SlotCar,
                DoneBig617 = entity.DoneBig617,
                DoneBig918 = entity.DoneBig918,
                CancelBig816 = entity.CancelBig816,
                CancelBig168 = entity.CancelBig168,
                Acceleration = entity.Acceleration,
                TopSpeed = entity.TopSpeed,
                Breaking = entity.Breaking,
                Handling = entity.Handling,
                Yes186 = entity.Yes186,
                No195 = entity.No195,
                Automatic = entity.Automatic,
                Manual = entity.Manual,
                Car00Name = entity.Car00Name,
                Car01Name = entity.Car01Name,
                Car02Name = entity.Car02Name,
                Car03Name = entity.Car03Name,
                Car04Name = entity.Car04Name,
                Car05Name = entity.Car05Name,
                Car06Name = entity.Car06Name,
                Car07Name = entity.Car07Name,
                Car08Name = entity.Car08Name,
                Car09Name = entity.Car09Name,
                Car10Name = entity.Car10Name,
                Car11Name = entity.Car11Name,
                Car12Name = entity.Car12Name,
                Car13Name = entity.Car13Name,
                Car14Name = entity.Car14Name
            };

            return model;
        }

        /// <summary>
        /// Converts the domain model into an entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="model">Localisation.</param>
        internal static LocalisationEntity ToEntity(this Localisation model)
        {
            LocalisationEntity entity = new LocalisationEntity
            {
                Unknown1 = model.Unknown1,
                Unknown2 = model.Unknown2,
                GameSetup = model.GameSetup,
                Location = model.Location,
                PlayerOneSmall = model.PlayerOneSmall,
                PlayerTwoSmall = model.PlayerOneSmall,
                Opponents = model.PlayerOneSmall,
                StartRace = model.PlayerOneSmall,
                ConnectBig = model.ConnectBig,
                Options = model.Options,
                Exit = model.Exit,
                GameType = model.GameType,
                RaceType = model.RaceType,
                Style = model.Style,
                CatchUp = model.CatchUp,
                Backwards = model.Backwards,
                Mirrored = model.Mirrored,
                NavigationDone = model.NavigationDone,
                NavigationCancel = model.NavigationCancel,
                OnePlayer = model.OnePlayer,
                SplitScreen = model.SplitScreen,
                ModemSmall = model.ModemSmall,
                SerialLinkSmall = model.SerialLinkSmall,
                NetworkSmall = model.NetworkSmall,
                SingleRace = model.SingleRace,
                Tournament = model.Tournament,
                Knockout = model.Knockout,
                Simulation = model.Simulation,
                Arcade = model.Arcade,
                Wild = model.Wild,
                Beginner = model.Beginner,
                Advanced = model.Advanced,
                SimulationShort = model.SimulationShort,
                ArcadeShort = model.ArcadeShort,
                SerialLinkBig = model.SerialLinkBig,
                ComPort = model.ComPort,
                ConnectSmall = model.ConnectSmall,
                CancelSmall = model.CancelSmall,
                Nr1 = model.Nr1,
                Nr2 = model.Nr2,
                Nr3 = model.Nr3,
                Nr4 = model.Nr4,
                ModemBig = model.ModemBig,
                ModemSmall2 = model.ModemSmall2,
                PhoneList = model.PhoneList,
                DeleteNumber = model.DeleteNumber,
                Dial = model.Dial,
                Answer = model.Answer,
                CancelBig2 = model.CancelBig2,
                NetworkBig = model.NetworkBig,
                Colour = model.Colour,
                Protocol = model.Protocol,
                Players = model.Players,
                CreateGame = model.CreateGame,
                JoinGame = model.JoinGame,
                NoGamesAvailable = model.NoGamesAvailable,
                Track00Name = model.Track00Name,
                Track02Name = model.Track02Name,
                Track03Name = model.Track03Name,
                Track04Name = model.Track04Name,
                Track05Name = model.Track05Name,
                Track06Name = model.Track06Name,
                Track07Name = model.Track07Name,
                Track08Name = model.Track08Name,
                LapsCount4 = model.LapsCount4,
                LapsCount8 = model.LapsCount8,
                LapsCount2 = model.LapsCount2,
                PlayerOneBig = model.PlayerOneBig,
                PlayerTwoBig = model.PlayerTwoBig,
                Car = model.Car,
                Transmission = model.Transmission,
                Colour218 = model.Colour218,
                Graph = model.Graph,
                Settings = model.Settings,
                Showcase = model.Showcase,
                SlotCar = model.SlotCar,
                DoneBig617 = model.DoneBig617,
                DoneBig918 = model.DoneBig918,
                CancelBig816 = model.CancelBig816,
                CancelBig168 = model.CancelBig168,
                Acceleration = model.Acceleration,
                TopSpeed = model.TopSpeed,
                Breaking = model.Breaking,
                Handling = model.Handling,
                Yes186 = model.Yes186,
                No195 = model.No195,
                Automatic = model.Automatic,
                Manual = model.Manual,
                Car00Name = model.Car00Name,
                Car01Name = model.Car01Name,
                Car02Name = model.Car02Name,
                Car03Name = model.Car03Name,
                Car04Name = model.Car04Name,
                Car05Name = model.Car05Name,
                Car06Name = model.Car06Name,
                Car07Name = model.Car07Name,
                Car08Name = model.Car08Name,
                Car09Name = model.Car09Name,
                Car10Name = model.Car10Name,
                Car11Name = model.Car11Name,
                Car12Name = model.Car12Name,
                Car13Name = model.Car13Name,
                Car14Name = model.Car14Name
            };

            return entity;
        }

        /// <summary>
        /// Converts the entities into domain models.
        /// </summary>
        /// <returns>The domain models.</returns>
        /// <param name="localisationEntities">Localisation entities.</param>
        internal static IEnumerable<Localisation> ToDomainModels(this IEnumerable<LocalisationEntity> localisationEntities)
        {
            IEnumerable<Localisation> localisations = localisationEntities.Select(localisationEntity => localisationEntity.ToDomainModel());

            return localisations;
        }

        /// <summary>
        /// Converts the domain models into entities.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="localisations">Localisations.</param>
        internal static IEnumerable<LocalisationEntity> ToEntities(this IEnumerable<Localisation> localisations)
        {
            IEnumerable<LocalisationEntity> localisationEntities = localisations.Select(localisation => localisation.ToEntity());

            return localisationEntities;
        }
    }
}
