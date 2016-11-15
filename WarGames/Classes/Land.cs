using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames
{
    public class Land : Countries
    {
        public Land(string CountryName, int Durability, int Strength, int Rep, float x, float y) : base(CountryName, Durability, Strength, Rep, x, y)
        {
        }
    }
}
