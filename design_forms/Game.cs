using System;

namespace design_forms
{
    public sealed class Game : IComparable, IComparable<Game>
    {
        public Game(string name, Emulator emulator, string location)
        {
            this.name = name;
            this.emulator = emulator;
            this.location = location;
        }

        public override string ToString()
        {
            return this.name;
        }

        public override bool Equals(object obj)
        {
            Game other = obj as Game;
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
            return CompareTo(obj as Game);
        }

        public int CompareTo(Game other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return 1;
            }
            else if (object.ReferenceEquals(other, this))
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

        public Emulator emulator
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
