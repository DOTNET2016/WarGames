using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames
{
    public class Countries
    {
        private string _countryName;
        private int _durability;
        public Countries(string CountryName, int Durability)
        {
            _countryName = CountryName;
            _durability = Durability;
        }
        public override string ToString()
        {
            return _countryName + ": " + _durability;
        }
    }
}
