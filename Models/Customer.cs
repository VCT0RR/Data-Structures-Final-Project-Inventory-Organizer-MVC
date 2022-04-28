using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventoryOrganizingFinalProject
{
    public class Customers
    {
        //6 private fields are declared
        private int? _customerId; //represents the customer's user ID as an integer
        private string? _password; //represents the user's password as a string
        private string? _fName; //represents the user's first name as a string
        private string? _lName; //represents the user's last name as a string
        private string? _email; //represents the user's email as a string
        private string? _phone; //represents the user's phone number as a string

        //public default no-arg constructor is used to initialized the values for each field
        public Customers()
        {
            _customerId = 0;
            _password = "";
            _fName = "";
            _lName = "";
            _email = "";
            _phone = "";
        }

        //public non-default constructor has 6 parameters and is used to set the values for all the fields
        public Customers(int customerId, string password, string fName, string lName, string email, string phone)
        {
            _customerId = customerId;
            _password = password;
            _fName = fName;
            _lName = lName;
            _email = email;
            _phone = phone;
        }

        //public property of data type int calls the getter and setter methods for the _customerId field
        public int? CustomerID
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        //public property of data type string calls the getter and setter methods for the _password field
        public string? Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //public property of data type string calls the getter and setter methods for the _fName field
        public string? FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        //public property of data type string calls the getter and setter methods for the _lName field
        public string? LastName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        //public property of data type string calls the getter and setter methods for the _email field
        public string? EmailAddress
        {
            get { return _email; }
            set { _email = value; }
        }

        //public property of data type string calls the getter and setter methods for the _phone field
        public string? PhoneNumber
        {
            get { return _phone; }
            set { _phone = value; }
        }


        //public overridden ToString() method of return type string returns the values for each property within the class in a properly formatted string
        public override string ToString()
        {
            return "\n*Account Summary Information*" + "\nUser ID: " + CustomerID + "\nUser Password: " + Password + "\nFirst Name: " + FirstName.ToUpper()
                + "\nLast Name: " + LastName.ToUpper() + "\nEmail: " + EmailAddress + "\nPhone Number: " + PhoneNumber + "\n";
        }
    }
}
