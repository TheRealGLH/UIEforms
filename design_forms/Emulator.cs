using System;

namespace design_forms
{
    public sealed class Emulator : IComparable, IComparable<Emulator>
    {
        public Emulator(string name, string platform, string developer, string location)
        {
            this.name = name;
            this.platform = platform;
            this.developer = developer;
            this.location = location;
        }

        public override string ToString()
        {
            return this.name;
        }

        public override bool Equals(object obj)
        {
            Emulator other = obj as Emulator;
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            else if (object.ReferenceEquals(other, this))
            {
                return true;
            }

            return this.name.Equals(other.name);
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            return CompareTo(obj as Emulator);
        }

        public int CompareTo(Emulator other)
        {
            if(object.ReferenceEquals(other, null))
            {
                return 1;
            }
            else if(object.ReferenceEquals(other, this))
            {
                return 0;
            }

            return this.name.CompareTo(other.name);
        }

        public string name
        {
            get;
            private set;
        }

        public string platform
        {
            get;
            set;
        }

        public string developer
        {
            get;
            set;
        }

        public string location
        {
            get;
            set;
        }
    }
}
