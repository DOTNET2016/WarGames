using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WarGames
{
    public class Countries
    {
        private string _countryName;
        private int _durability;
        private int _strength;
        private int _rep;

        public int Durability
        {
            get
            {
                return _durability;
            }

            set
            {
                _durability = value;
            }
        }

        public int CStrength
        {
            get
            {
                return _strength;
            }

            set
            {
                _strength = value;
            }
        }

        public int CRep
        {
            get
            {
                return _rep;
            }

            set
            {
                _rep = value;
            }
        }

        public Countries(string CountryName, int Durability, int Strength, int Rep)
        {
            _countryName = CountryName;
            _durability = Durability;
            CStrength = Strength;
            CRep = Rep;
        }

        public override string ToString()
        {
            return _countryName + ": " + Durability;
        }
    }
}
