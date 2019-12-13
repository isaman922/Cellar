using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellar.Models
{
    [Serializable]
    public class Collection
    {
        /// <summary>
        /// Class describing one specific cellared collection, including bottles, owner, and authentication data.
        /// </summary>

        private List<Bottle> bottles;
        private string firstName;
        private string lastName;
        private string userName;
        private int pinNumber;

        public List<Bottle> Bottles { get => bottles; set => bottles = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserName { get => userName; set => userName = value; }
        public int PinNumber { get => pinNumber; set => pinNumber = value; }

        public Collection(string fName, string lName, string user, int pin)
        {
            firstName = fName;
            lastName = lName;
            userName = user;
            pinNumber = pin;
        }

        public Collection(string fName, string lName, string user, int pin, List<Bottle> list)
        {
            firstName = fName;
            lastName = lName;
            userName = user;
            pinNumber = pin;

            foreach (Bottle b in list)
            {
                bottles.Add(b);
            }
        }

        public int BottleCount()
        {
            //Retrieve and return number of bottles in collection
            int count = bottles.Count;
            return count;
        }

        public decimal TotalValue()
        {
            //Retrieve and return total value of the bottles in the collection
            decimal sum = 0;

            foreach (Bottle b in  bottles)
            {
                sum += b.Cost;
            }

            return sum;
        }

        public decimal AvgBottleCost()
        {
            //Retrieve and return average cost of a bottle in the collection
            decimal cost = TotalValue() / BottleCount();
            return cost;
        }

        public double AvgBottleAge()
        {
            //Retrieve and return average age of a bottle in the collection
            double totalAge = 0;

            foreach (Bottle b in bottles)
            {
                totalAge += (DateTime.Today.Year - b.Vintage);
            }

            double age = totalAge / BottleCount();

            return age;
        }

        public int AvgPeakYear()
        {
            //Retrieve and return average peak drinking year of a bottle in the collection
            int totalYear = 0;

            foreach (Bottle b in bottles)
            {
                totalYear += b.DrinkByPeak;
            }

            int year = totalYear / BottleCount();

            return year;
        }

        public List<string[]> CountryBreakdown()
        {
            //Retrieve and return 2-dimensional array of country and number of bottles from that country
            List<string[]> stats = new List<string[]>();

            foreach (Bottle b in bottles)
            {
                foreach (var entry in stats)
                {
                    if (b.Country == entry[0])
                    {
                        entry[1] = (Convert.ToInt32(entry[1]) + 1).ToString();
                    }
                    else
                    {
                        stats.Add(new string[] { b.Country, "1" });
                    }
                }
            }

            return stats;
        }

        public int[] CategoryBreakdown()
        {
            //Retrieve and return array of number of bottles in each category 0-7
            int[] stats = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (Bottle b in bottles)
            {
                stats[b.TypeCode]++;
            }

            return stats;
        }
    }
}
