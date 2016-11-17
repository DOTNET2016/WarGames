using System;
using System.Collections.Generic;

namespace WarGames
{
    public class WOPR
    {
        static Random rnd = new Random();
        public List<Countries> countriesAtWar = new List<Countries>();
        public List<Countries> defeatedCountries = new List<Countries>();

        //War Operation Plan Responce
        public WOPR()
        {
            
        }

        public void CountryList()
        {
            countriesAtWar.Add(new Land("USA", 20, 5, 4, 223, 239));
            countriesAtWar.Add(new Land("Russia", 20, 5, 4, 1006, 121));
            countriesAtWar.Add(new Land("UK", 10, 4, 7, 654, 156));
            countriesAtWar.Add(new Land("China", 20, 5, 5, 1105, 255));
            countriesAtWar.Add(new Land("France", 15, 3, 7, 667, 189));
            countriesAtWar.Add(new Land("India", 17, 4, 7, 1028, 322));
            countriesAtWar.Add(new Land("Germany", 15, 4, 8, 699, 164));
            countriesAtWar.Add(new Land("Japan", 10, 3, 7, 1291, 240));
            countriesAtWar.Add(new Land("Sweden", 13, 2, 10, 721, 114));
            countriesAtWar.Add(new Land("North Korea", 14, 2, 1, 1226, 223));
        }
        public dynamic RandomCountries()
        {
            Countries randomCountryOne, randomCountryTwo;
            randomCountryOne = countriesAtWar[rnd.Next(countriesAtWar.Count)];
            randomCountryTwo = countriesAtWar[rnd.Next(countriesAtWar.Count)];
            do
            {
                if (randomCountryOne == randomCountryTwo)
                {
                    randomCountryTwo = countriesAtWar[rnd.Next(countriesAtWar.Count)];
                }
                else
                {
                    break;
                }
            } while (randomCountryOne == randomCountryTwo);
            int i = 1;
            while (i == 1)
            {
                randomCountryTwo.Durability -= randomCountryOne.Strength;
                if (randomCountryTwo.Durability <= 0)
                {
                countriesAtWar.Remove(randomCountryTwo);
                defeatedCountries.Add(randomCountryTwo);
                }
                i--;
            }

            dynamic temp = new System.Dynamic.ExpandoObject();
            temp.x1 = randomCountryOne.XCoord;
            temp.y1 = randomCountryOne.YCoord;
            temp.x2 = randomCountryTwo.XCoord;
            temp.y2 = randomCountryTwo.YCoord;
            return temp;
        }
    }
}
