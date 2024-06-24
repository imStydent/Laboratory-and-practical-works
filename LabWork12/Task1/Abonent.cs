using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    record Abonent
    {
        public Abonent() : this("неизвестно", 88005553535, 100.99) { }

        public Abonent(string fullName, long phoneNumber, double callTime)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public double CallTime { get; set; }
    }
}
