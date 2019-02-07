using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        // :this(0) -> defaultniqt constr izvikva tozi s parametri
        public Customer()  
            : this (0) 
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

     public List<Address> AddressList
        {
            get;
            set;
        }


        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        //prop+tabtab = get;set;
        //ptopg+tabtab=get;private set;

        public string FirstName
        {
          get;
          set;
        }

        public string EmailAddress
        {
            get;
            set;
        }

        public int CustomerId
        {
            get;
            private set;
        }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }
                              
                    fullName += FirstName;
                
                return fullName;
            }
        }



        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if(string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
