namespace Task1
{
    internal class Apartment
    {
        public Apartment() : this("Улица Абрамова 5", 7, 21.4) { }

        public Apartment(string address, int roomsCount, double square)
        {
            Address = address;
            RoomsCount = roomsCount;
            Square = square;
        }

        public string Address { get; set; }

        public int RoomsCount { get; set; }

        public double Square { get; set; }

        public static Apartment operator ++(Apartment apartment)
            => new(apartment.Address, apartment.RoomsCount + 1, apartment.Square);

        public static Apartment operator +(Apartment apartment1, Apartment apartment2)
            => new(apartment1.Address, apartment1.RoomsCount, apartment1.Square + apartment2.Square);

        public static bool operator !=(Apartment apartment1, Apartment apartment2)
            => apartment1.Address != apartment2.Address || 
            apartment1.RoomsCount != apartment2.RoomsCount ||
            apartment1.Square != apartment2.Square;
       
        public static bool operator ==(Apartment apartment1, Apartment apartment2)
            => apartment1.Address == apartment2.Address && 
            apartment1.RoomsCount == apartment2.RoomsCount && 
            apartment1.Square == apartment2.Square;

        public static bool operator true(Apartment apartment)
            => apartment.Square >= 0;

        public static bool operator false(Apartment apartment)
            => apartment.Square < 0;

        public void Print()
        {
            Console.WriteLine($"Адрес: {Address}, количество комнат - {RoomsCount}, площадь - {Square}");
        }
    }
}
