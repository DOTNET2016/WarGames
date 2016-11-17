﻿using System;
using System.Collections.Generic;

namespace WarGames
{
    public class WOPR
    {
        static Random rnd = new Random();
        public List<Countries> countriesAtWar = new List<Countries>();
        public List<Countries> defeatedCountries = new List<Countries>();

        Countries randomCountryOne, randomCountryTwo;

        //War Operation Plan Responce
        public WOPR()
        {
            
        }

        public void CountryList()
        {
            countriesAtWar.Add(new Land("USA", 20, 8, 2, 223, 239));
            countriesAtWar.Add(new Land("Russia", 20, 8, 1, 1006, 121));
            countriesAtWar.Add(new Land("UK", 10, 6, 3, 654, 156));
            countriesAtWar.Add(new Land("China", 20, 6, 2, 1105, 255));
            countriesAtWar.Add(new Land("France", 15, 5, 4, 667, 189));
            countriesAtWar.Add(new Land("India", 17, 5, 3, 1028, 322));
            countriesAtWar.Add(new Land("Germany", 15, 7, 4, 699, 164));
            countriesAtWar.Add(new Land("Japan", 10, 4, 3, 1291, 240));
            countriesAtWar.Add(new Land("Sweden", 13, 6, 5, 721, 114));
            countriesAtWar.Add(new Land("North Korea", 10, 3, 1, 1226, 223));
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
                if (randomCountryOne.Strength - randomCountryTwo.Reputation <= 0)
                {
                    break;
                }
                else
                    randomCountryTwo.Durability -= (randomCountryOne.Strength - randomCountryTwo.Reputation);
                if (randomCountryTwo.Durability <= 0)
                {
                    randomCountryTwo.Durability = 0;
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
