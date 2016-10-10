using System.Collections.Generic;
using System.Globalization;

namespace design_forms
{
    public sealed class ObjectManager
    {
        public static readonly CultureInfo[] languages = new CultureInfo[]
        {
            new CultureInfo("en-US"),
            new CultureInfo("nl-NL")
        };

        private readonly SortedSet<Emulator> _emulators;
        private readonly SortedSet<Game> _games;
        private readonly SortedSet<Game> _favourites;

        static ObjectManager()
        {
            instance = new ObjectManager();
        }

        public ObjectManager()
        {
            this._emulators = new SortedSet<Emulator>();
            this._games = new SortedSet<Game>();
            this._favourites = new SortedSet<Game>();


        }

        public SortedSet<Emulator> emulators
        {
            get
            {
                return this._emulators;
            }
        }

        public SortedSet<Game> games
        {
            get
            {
                return this._games;
            }
        }

        public SortedSet<Game> favourites
        {
            get
            {
                return this._favourites;
            }
        }

        public static ObjectManager instance
        {
            get;
            private set;
        }
    }
}
