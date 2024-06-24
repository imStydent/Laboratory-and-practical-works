namespace Task1
{
    internal class Apartment
    {
        string _address;
        int _roomsCount;
        double _square;

        public Apartment() : this("неизвестен", 0, 0) { }

        public Apartment(string address, int roomsCount, double square)
        {
            Address = address;
            RoomsCount = roomsCount;
            Square = square;
        }

        public string Address
        {
            get => _address;
            set
            {
                value = value.Trim();
                if (_address != value && value != "")
                    _address = value;
            }
        }

        public int RoomsCount
        {
            get => _roomsCount;
            set
            {
                if (value > 0)
                    _roomsCount = value;
            }
        }

        public double Square
        {
            get => _square;
            set
            {
                if (value > 0)
                    _square = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Адрес: {Address}, количество комнат - {RoomsCount}, площадь - {Square}");
        }
    }
}