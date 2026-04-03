using System;
using System.Collections.Generic;
using System.Linq;

namespace NFS2Tools.Models
{
    public class CarType : IEquatable<CarType>
    {
        static readonly Dictionary<string, CarType> values = new()
        {
            { nameof(McLarenF1), new CarType(0, nameof(McLarenF1)) },
            { nameof(FerrariF50), new CarType(1, nameof(FerrariF50)) },
            { nameof(Ferrari355F1), new CarType(2, nameof(Ferrari355F1)) },
            { nameof(FordGT90), new CarType(3, nameof(FordGT90)) },
            { nameof(FordIndigo), new CarType(4, nameof(FordIndigo)) },
            { nameof(FordMachIII), new CarType(5, nameof(FordMachIII)) },
            { nameof(JaguarXJ220), new CarType(6, nameof(JaguarXJ220)) },
            { nameof(LotusGT1), new CarType(7, nameof(LotusGT1)) },
            { nameof(LotusEspritV8), new CarType(8, nameof(LotusEspritV8)) },
            { nameof(NazcaC2), new CarType(9, nameof(NazcaC2)) },
            { nameof(ItaldesignCala), new CarType(10, nameof(ItaldesignCala)) },
            { nameof(Isdera112i), new CarType(11, nameof(Isdera112i)) },
        };

        public short Id { get; }

        public string Name { get; }

        CarType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public static CarType McLarenF1 => values[nameof(McLarenF1)];
        public static CarType FerrariF50 => values[nameof(FerrariF50)];
        public static CarType Ferrari355F1 => values[nameof(Ferrari355F1)];
        public static CarType FordGT90 => values[nameof(FordGT90)];
        public static CarType FordIndigo => values[nameof(FordIndigo)];
        public static CarType FordMachIII => values[nameof(FordMachIII)];
        public static CarType JaguarXJ220 => values[nameof(JaguarXJ220)];
        public static CarType LotusGT1 => values[nameof(LotusGT1)];
        public static CarType LotusEspritV8 => values[nameof(LotusEspritV8)];
        public static CarType NazcaC2 => values[nameof(NazcaC2)];
        public static CarType ItaldesignCala => values[nameof(ItaldesignCala)];
        public static CarType Isdera112i => values[nameof(Isdera112i)];

        public static Array GetValues() => values.Values.ToArray();

        public bool Equals(CarType other)
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

            return Equals((CarType)obj);
        }

        public override int GetHashCode() => $"{nameof(CarType)}:{Id}".GetHashCode();

        public override string ToString() => Name;

        public static CarType FromId(short value)
        {
            if (values.Values.Any(v => v.Id == value))
            {
                return values.Values.First(v => v.Id == value);
            }

            return McLarenF1;
        }

        public static CarType FromName(string value)
        {
            if (values.ContainsKey(value))
            {
                return values[value];
            }

            if (values.Values.Any(v => v.Name.Equals(value)))
            {
                return values.Values.First(v => v.Name.Equals(value));
            }

            return McLarenF1;
        }

        public static bool operator ==(CarType current, CarType other) => current.Equals(other);
        public static bool operator !=(CarType current, CarType other) => !current.Equals(other);

        public static implicit operator short(CarType obj) => obj.Id;
        public static implicit operator CarType(short id) => FromId(id);

        public static implicit operator string(CarType obj) => obj.Name;
        public static implicit operator CarType(string name) => FromName(name);
    }
}
