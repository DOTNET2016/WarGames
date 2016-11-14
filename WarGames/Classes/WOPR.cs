using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames
{
    public class WOPR
    {
        public List<Countries> countriesAtWar = new List<Countries>();

        //War Operation Plan Responce
        public WOPR()
        {
            
        }
        public void CountryList()
        {
            countriesAtWar.Add(new Countries("USA", 20, 5, 4));
            countriesAtWar.Add(new Countries("Russia", 20, 5, 4));
            countriesAtWar.Add(new Countries("UK", 10, 3, 7));
            countriesAtWar.Add(new Countries("China", 20, 5, 5));
            countriesAtWar.Add(new Countries("France", 15, 3, 7));
            countriesAtWar.Add(new Countries("India", 17, 4, 7));
            countriesAtWar.Add(new Countries("Germany", 15, 4, 8));
            countriesAtWar.Add(new Countries("Japan", 10, 3, 7));
            countriesAtWar.Add(new Countries("Sweden", 13, 2, 10));
            countriesAtWar.Add(new Countries("North Korea", 14, 6, 1));
        }
    }
}
