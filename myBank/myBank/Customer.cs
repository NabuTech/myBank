using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class Customer
    {
        public string CustomerNumber { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }

        public Customer(string customerNumber, string name, string contactDetails)
        {
            CustomerNumber = customerNumber;
            Name = name;
            ContactDetails = contactDetails;
        }
    }

}
