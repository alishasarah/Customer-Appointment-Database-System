using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969AlishaCrockford
{
    public class CustomerInfo
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public CustomerInfo()
        {

        }
        public CustomerInfo(string custName, string _phone, string _address, string _city, string _country)
        {
            customerName = custName;
            phone = _phone;
            address = _address;
            city = _city;
            country = _country;
        }
    }
}
