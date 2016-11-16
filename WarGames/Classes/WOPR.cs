using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames
{
    public class WOPR
    {
        static Random rnd = new Random();
        public List<Countries> countriesAtWar = new List<Countries>();

        //War Operation Plan Responce
        public WOPR()
        {
            
        }

        public void CountryList()
        {
            countriesAtWar.Add(new Land("USA", 20, 5, 4, 223, 239));
            countriesAtWar.Add(new Land("Russia", 20, 5, 4, 1006, 121));
            countriesAtWar.Add(new Land("UK", 10, 3, 7, 654, 156));
            countriesAtWar.Add(new Land("China", 20, 5, 5, 1105, 255));
            countriesAtWar.Add(new Land("France", 15, 3, 7, 667, 189));
            countriesAtWar.Add(new Land("India", 17, 4, 7, 1028, 322));
            countriesAtWar.Add(new Land("Germany", 15, 4, 8, 699, 164));
            countriesAtWar.Add(new Land("Japan", 10, 3, 7, 1291, 240));
            countriesAtWar.Add(new Land("Sweden", 13, 2, 10, 721, 114));
            countriesAtWar.Add(new Land("North Korea", 14, 6, 1, 1226, 223));
        }
        public dynamic RandomCountryOne()
        {
            Countries randomCountryOne;

            randomCountryOne = countriesAtWar[rnd.Next(countriesAtWar.Count)];
            //if (randomCountryOne.Durability == 0)
            //{
            //    countriesAtWar.Remove(randomCountryOne);
            //    randomCountryOne = null;
            //}
            //randomCountryOne = countriesAtWar[rnd.Next(countriesAtWar.Count)];
            dynamic temp = new System.Dynamic.ExpandoObject();
            temp.x = randomCountryOne.XCoord;
            temp.y = randomCountryOne.YCoord;
            temp.str = randomCountryOne.Strength;
            return temp;
            //do some stuff here to get countries to attrack echo other randomly, we can try make it more advance later
        }

        public dynamic RandomCountryTwo()
        {
            var DefCountry = decreaseDurStr();
            dynamic temp = new System.Dynamic.ExpandoObject();
            temp.x = DefCountry.XCoord;
            temp.y = DefCountry.YCoord;
            return temp;
            //do some stuff here to get countries to attrack echo other randomly, we can try make it more advance later
        }

        private Countries decreaseDurStr()
        {
            Countries randomCountryTwo;
            var checkStr = RandomCountryOne();
            randomCountryTwo = countriesAtWar[rnd.Next(countriesAtWar.Count)];

            int i = 1;
            while (i == 1)
            {
                //if (randomCountryTwo.Durability <= 0)
                //{
                //    do
                //    {
                //        //dont let the endurance hit 0 on all countries, or it will be stuck in a endless loop :P
                //        randomCountryTwo = countriesAtWar[rnd.Next(countriesAtWar.Count)];
                //    } while (i == 0 || randomCountryTwo.Durability <= 0);
                //}
                randomCountryTwo.Durability -= (checkStr.str);
                if (randomCountryTwo.Durability <= 0)
                {
                    countriesAtWar.Remove(randomCountryTwo);
                }
                i--;
            }  
            Countries DefCountry = randomCountryTwo;

            return DefCountry;
        }

        public void SortDurability()
        {
            countriesAtWar.Sort();
        }
    }
}
