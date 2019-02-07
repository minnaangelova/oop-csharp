using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository
        {
            get;
            set;
        }

        public CustomerRepository ()
        {
            addressRepository = new AddressRepository();
        }
        

        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            //Create the instance of the Customer class
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.
                RetrieveByCustomerId(customerId).ToList();
            
            //Code that retrieves the defined customer

            //Temporary hard coded values
            //to return a populated customer
            if (customerId == 1)
            { 
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
            

        //Retrieves a list of customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        //Saves the current customer
        public bool Save(Customer customer)
        {
            //Code that saves the defined customer
            return true;
        }
    }
}
