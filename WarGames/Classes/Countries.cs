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
        private int _durabillity;
        public Countries(string CountryName, int Durabillity)
        {
            _countryName = CountryName;
            _durabillity = Durabillity;
        }
        public override string ToString()
        {
            return _countryName + ": " + _durabillity;
        }
    }
}
