using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_M_House_Rental
{
    internal class Tenant
    {


        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }

        public Tenant(string name, int phoneNumber, string gender)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }
    }
}