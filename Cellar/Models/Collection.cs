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
    }
}
