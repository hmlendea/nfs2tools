using System;
using System.Collections.Generic;
using System.Linq;

namespace NFS2Tools.DataAccess.IO
{
    public class FileType : IEquatable<FileType>
    {
        static readonly Dictionary<string, FileType> values = new()
        {
            { nameof(XML), new FileType(0, nameof(XML)) },
            { nameof(STF), new FileType(1, nameof(STF)) },
        };

        public short Id { get; }

        public string Name { get; }

        FileType(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public static FileType XML => values[nameof(XML)];
        public static FileType STF => values[nameof(STF)];

        public static Array GetValues() => values.Values.ToArray();

        public bool Equals(FileType other)
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

            return Equals((FileType)obj);
        }

        public override int GetHashCode() => $"{nameof(FileType)}:{Id}".GetHashCode();

        public override string ToString() => Name;

        public static FileType FromId(short value)
        {
            if (values.Values.Any(v => v.Id == value))
            {
                return values.Values.First(v => v.Id == value);
            }

            return XML;
        }

        public static FileType FromName(string value)
        {
            if (values.ContainsKey(value))
            {
                return values[value];
            }

            if (values.Values.Any(v => v.Name.Equals(value)))
            {
                return values.Values.First(v => v.Name.Equals(value));
            }

            return XML;
        }

        public static bool operator ==(FileType current, FileType other) => current.Equals(other);
        public static bool operator !=(FileType current, FileType other) => !current.Equals(other);

        public static implicit operator short(FileType obj) => obj.Id;
        public static implicit operator FileType(short id) => FromId(id);

        public static implicit operator string(FileType obj) => obj.Name;
        public static implicit operator FileType(string name) => FromName(name);
    }
}
