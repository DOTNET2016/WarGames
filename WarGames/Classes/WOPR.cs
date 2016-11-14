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
            countriesAtWar.Add(new Countries("USA", 20, 5, 4, 223, 239));
            countriesAtWar.Add(new Countries("Russia", 20, 5, 4, 1006, 121));
            countriesAtWar.Add(new Countries("UK", 10, 3, 7, 654, 156));
            countriesAtWar.Add(new Countries("China", 20, 5, 5, 1105, 255));
            countriesAtWar.Add(new Countries("France", 15, 3, 7, 667, 189));
            countriesAtWar.Add(new Countries("India", 17, 4, 7, 1028, 322));
            countriesAtWar.Add(new Countries("Germany", 15, 4, 8, 699, 164));
            countriesAtWar.Add(new Countries("Japan", 10, 3, 7, 1291, 240));
            countriesAtWar.Add(new Countries("Sweden", 13, 2, 10, 721, 114));
            countriesAtWar.Add(new Countries("North Korea", 14, 6, 1, 1226, 223));
        }
    }
}
