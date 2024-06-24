using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task4
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            char[] letters = Name.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            Name = new string(letters);

            return $"{Name}; {Price:F2}; {ExpirationDate:yyyy-MM-dd}";
        }
    }
}
