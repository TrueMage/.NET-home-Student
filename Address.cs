using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using home_06Sep.Exceptions;

namespace home_06Sep
{
    internal class Address
    {
        private string _street;
        private string _city;
        private string _zipCode;
        private string _country;

        public Address()
        {
            _street = "not given";
            _city = "not given";
            _zipCode = "not given";
            _country = "not given";
        }

        public Address(string street, string city, string zipCode, string country)
        {
            _street = street;
            _city = city;
            _zipCode = zipCode;
            _country = country;
        }

        #region Getter
        public string getStreet()
        {
            return _street;
        }

        public string getCity()
        {
            return _city;
        }

        public string getZipCode()
        {
            return _zipCode;
        }

        public string getCountry()
        {
            return _country;
        }
        #endregion

        #region Setter

        public void setStreet(string street)
        {
            if(street.Length > 20) throw new StringIsTooLongException();
            _street = street;
        }

        public void setCity(string city)
        {
            if (city.Length > 20) throw new StringIsTooLongException();
            _city = city;
        }

        public void SetZipCode(string zipcode)
        {
            if (zipcode.Length > 20) throw new StringIsTooLongException();
            _zipCode = zipcode;
        }

        public void setCountry(string country)
        {
            if (country.Length > 20) throw new StringIsTooLongException();
            _country = country;
        }

        #endregion

        public void print()
        {
            bool isEmpty = true;

            if(_street != "not given")
            {
                isEmpty = false;
                Console.Write(_street + " ");
            }

            if (_city != "not given")
            {   
                isEmpty = false;
                Console.Write(_city + " ");
            }

            if (_zipCode != "not given")
            {
                isEmpty = false;
                Console.Write(_zipCode + " ");
            }

            if (_country != "not given")
            {
                isEmpty = false;
                Console.Write(_country + " ");
            }

            if (isEmpty) {
                Console.WriteLine("not given");
            }
        }
    }
}
