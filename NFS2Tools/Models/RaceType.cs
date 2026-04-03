using System;
using System.Collections.Generic;
using System.Linq;

namespace NFS2Tools.Models
{
    public class RaceType : IEquatable<RaceType>
    {
        static readonly Dictionary<string, RaceType> values = new()
        {
            { nameof(Simulation), new RaceType(0, nameof(Simulation)) },
            { nameof(Wild), new RaceType(1, nameof(Wild)) },
            { nameof(Arcade), new RaceType(2, nameof(Arcade)) }
        };

        public short Id { get; }

        public string Name { get; }

        RaceType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public static RaceType Simulation => values[nameof(Simulation)];
        public static RaceType Wild => values[nameof(Wild)];
        public static RaceType Arcade => values[nameof(Arcade)];

        public static Array GetValues() => values.Values.ToArray();

        public bool Equals(RaceType other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((RaceType)obj);
        }

        public override int GetHashCode() => $"{nameof(RaceType)}:{Id}".GetHashCode();

        public override string ToString() => Name;

        public static RaceType FromId(short value)
        {
            if (values.Values.Any(v => v.Id == value))
            {
                return values.Values.First(v => v.Id == value);
            }

            return Simulation;
        }

        public static RaceType FromName(string value)
        {
            if (values.ContainsKey(value))
            {
                return values[value];
            }

            if (values.Values.Any(v => v.Name.Equals(value)))
            {
                return values.Values.First(v => v.Name.Equals(value));
            }

            return Simulation;
        }

        public static bool operator ==(RaceType current, RaceType other) => current.Equals(other);
        public static bool operator !=(RaceType current, RaceType other) => !current.Equals(other);

        public static implicit operator short(RaceType obj) => obj.Id;
        public static implicit operator RaceType(short id) => FromId(id);

        public static implicit operator string(RaceType obj) => obj.Name;
        public static implicit operator RaceType(string name) => FromName(name);
    }
}
