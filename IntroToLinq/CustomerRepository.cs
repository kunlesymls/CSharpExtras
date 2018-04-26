using System.Collections.Generic;
using System.Linq;

namespace IntroToLinq
{
    public class CustomerRepository
    {

        public Customer FindCustomer(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;
            //foreach (var customer in customerList)
            //{
            //    if (customer.CustomerId == customerId)
            //    {
            //        foundCustomer = customer;
            //        break;
            //    }
            //}
            foundCustomer = customerList.FirstOrDefault(x => x.CustomerId == customerId);
            return foundCustomer;
        }

        public List<Customer> RetrieveCustomer()
        {
            var customers = new List<Customer>
            {
                new Customer()
                {
                    CustomerId = 1, FirstName = "Joe", LastName = "Ken", EmailAddress = "joe@gmail.com", CustomerType = "1"
                },
                new Customer()
                {
                    CustomerId = 2, FirstName = "Ajayi", LastName = "Lekan", EmailAddress = "ajayi@gmail.com", CustomerType = "2"
                },
                  new Customer()
                {
                    CustomerId = 3, FirstName = "Bola", LastName = "Ala", EmailAddress = "bola@gmail.com", CustomerType = "1"
                },
                   new Customer()
                {
                    CustomerId = 4, FirstName = "Emma", LastName = "Loris", EmailAddress = "ema@gmail.com", CustomerType = "2"
                },
                    new Customer()
                {
                    CustomerId = 1, FirstName = "kemi", LastName = "Lola", EmailAddress = "lola@gmail.com", CustomerType = "3"
                },
            };
            return customers;
        }
    }
}
