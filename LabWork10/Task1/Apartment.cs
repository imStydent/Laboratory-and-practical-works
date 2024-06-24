using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Apartment : IComparable, IComparable<Apartment>, IEquatable<Apartment>, ICloneable
    {
        public Apartment() : this("неизвестен", 0, 0) { }

        public Apartment(string address, int roomsCount, double square)
        {
            Address = address;
            RoomsCount = roomsCount;
            Square = square;
        }

        public string Address { get; set; }

        public int RoomsCount { get; set; }

        public double Square { get; set; }

        public object Clone()
        {
            return new Apartment(Address, RoomsCount, Square);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Apartment apartment)
                return Square.CompareTo(apartment.Square);
            else return -1;
        }

        public int CompareTo(Apartment? other)
        {
            if (other is Apartment apartment)
                return Square.CompareTo(apartment.Square);
            else return -1;
        }

        public bool Equals(Apartment? other)
        {
            if (other is Apartment apartment)
                return Address.Equals(apartment.Address) && RoomsCount.Equals(apartment.RoomsCount) && Square.Equals(apartment.Square);
            else return false;
        }

        public void Print()
        {
            Console.WriteLine($"Адрес: {Address}, количество комнат - {RoomsCount}, площадь - {Square}");
        }
    }
}
