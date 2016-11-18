using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace WarGames
{
    public class WOPR
    {
        static Random rnd = new Random();
        public List<Countries> countriesAtWar = new List<Countries>();
        public List<Countries> defeatedCountries = new List<Countries>();

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        public Font myFont1; //Font size 20
        public Font myFont2; //Font size 25
        public Font myFont3; //Font size 40

        //War Operation Plan Responce
        public WOPR()
        {
            byte[] fontData = Properties.Resources.WarGames;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.WarGames.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.WarGames.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            myFont1 = new Font(fonts.Families[0], 20.0F);
            myFont2 = new Font(fonts.Families[0], 20.0F);
            myFont3 = new Font(fonts.Families[0], 40.0F);
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

            int attackStr = randomCountryOne.Strength;

            int i = 1;     
            while (i == 1)
            {
                if (randomCountryOne.Strength - randomCountryTwo.Reputation <= 0)
                {
                    break;
                }
                else
                    
                    randomCountryTwo.Durability -= (attackStr - randomCountryTwo.Reputation);
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
