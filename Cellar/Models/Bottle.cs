using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellar.Models
{
    [Serializable]
    public class Bottle
    {
        /// <summary>
        /// 
        /// </summary>

        //Variables and properties:
        private string bottleName;
        private string producer;
        private int vintage;
        private string country;
        private string subregion;
        private string styleOrVarietal;
        private string size;
        private int drinkByStart;
        private int drinkByEnd;
        private int drinkByPeak;
        private decimal cost;
        private string location;
        private int typeCode;
        private int importanceCode;
        private List<string[]> ratings;
        private string notes;
        private string serializedLabelImage;

        public string BottleName { get => bottleName; set => bottleName = value; }
        public string Producer { get => producer; set => producer = value; }
        public int Vintage { get => vintage; set => vintage = value; }
        public string Country { get => country; set => country = value; }
        public string Subregion { get => subregion; set => subregion = value; }
        public string StyleOrVarietal { get => styleOrVarietal; set => styleOrVarietal = value; }
        public string Size { get => size; set => size = value; }
        public int DrinkByStart { get => drinkByStart; set => drinkByStart = value; }
        public int DrinkByEnd { get => drinkByEnd; set => drinkByEnd = value; }
        public int DrinkByPeak { get => drinkByPeak; set => drinkByPeak = value; }
        public decimal Cost { get => cost; set => cost = value; }
        public string Location { get => location; set => location = value; }
        public int TypeCode { get => typeCode; set => typeCode = value; }
        public int ImportanceCode { get => importanceCode; set => importanceCode = value; }
        public List<string[]> Ratings { get => ratings; set => ratings = value; }
        public string Notes { get => notes; set => notes = value; }
        public string SerializedLabelImage { get => serializedLabelImage; set => serializedLabelImage = value; }

        public Bottle(string name, string prod, int vint, string originCountry, string originSub, string style,
            string bottleSize, int drinkS, int drinkE, int peak, decimal bottleCost, string loc, int type,
            int importance, List<string[]> criticRatings, string memo, string photoSerialized)
        {
            bottleName = name;
            producer = prod;
            vintage = vint;
            country = originCountry;
            subregion = originSub;
            styleOrVarietal = style;
            size = bottleSize;
            drinkByStart = drinkS;
            drinkByEnd = drinkE;
            drinkByPeak = peak;
            cost = bottleCost;
            location = loc;
            typeCode = type;
            importanceCode = importance;
            ratings = new List<string[]>();
            notes = memo;
            serializedLabelImage = photoSerialized;

            foreach (string[] rating in criticRatings)
            {
                ratings.Add(rating);
            }
        }

        public override string ToString()
        {
            //Reurn the string to be displayed in the inventory list
            //string importanceText = "";
            //switch (importanceCode)
            //{
            //    case 0:
            //        importanceText = "Ceremonial";
            //        break;
            //    case 1:
            //        importanceText = "Special";
            //        break;
            //    case 2:
            //        importanceText = "Casual";
            //        break;
            //    case 3:
            //        importanceText = "Everyday";
            //        break;
            //}

            string bottleSummary = "";
            if (vintage != 0)
            {
                bottleSummary = $"{Vintage} {BottleName}, {Subregion}, {Country}, Best {DrinkByStart} - {DrinkByEnd}";
            }
            else
            {
                bottleSummary = $"N/V  {BottleName}, {Subregion}, {Country}, Best {DrinkByStart} - {DrinkByEnd}";
            }
            return bottleSummary;
        }

        public string ToOpenString()
        {
            //Return the string to be displayed on the dashboard of bottles to open

            string summary = "";
            if (vintage != 0)
            {
                summary = $"{Vintage + " " + BottleName}   *** Drink {DrinkByStart} - {DrinkByEnd} ***";
            }
            else
            {
                summary = $"{"N/V  " + BottleName}   *** Drink {DrinkByStart} - {DrinkByEnd} ***";
            }
            return summary;
        }
    }
}
