using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaBooking
{
    class CustomerRecords
    {
        List<Customer> custlist = null;

        public CustomerRecords()
        {
            custlist = new List<Customer>();
            Customer c1 = new Customer(1, "charan", "charan123", 10000.00, 987654321, "chennai");
            Customer c2 = new Customer(2, "AK", "charan123", 10000.00, 987654321, "chennai");
            custlist.Add(c1);
            custlist.Add(c2);
        }

        public void add(Customer customer)
        {
            custlist.Add(customer);
        }

        public Customer getCustomer(int customerId)
        {
            return custlist.Find(c => c.CustomerId == customerId);
        }
    }
}
