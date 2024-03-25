using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class Customer
    {
        private static int nextCustomerNumber = 1;

        public int CustomerNumber { get; private set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }

        public Customer(string name, string contactDetails)
        {
            CustomerNumber = nextCustomerNumber++;
            Name = name;
            ContactDetails = contactDetails;
        }
    }

}
