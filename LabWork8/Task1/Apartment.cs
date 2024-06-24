namespace Task1
{
    internal class Apartment
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

        public void Print()
        {
            Console.WriteLine($"Адрес: {Address}, количество комнат - {RoomsCount}, площадь - {Square}");
        }

        public override string ToString() => $"Адрес: {Address}, количество комнат - {RoomsCount}, площадь - {Square}";

        public override bool Equals(object? obj)
        {
            Apartment apartment = obj as Apartment;
            return Address == apartment.Address && RoomsCount == apartment.RoomsCount && Square == apartment.Square;
        }
    }
}
